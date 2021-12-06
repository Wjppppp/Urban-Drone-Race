using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public GameObject obj;
    public Transform checkPoints;
    public Text ScoreText;
    public Text Time;
    public int GameTime = 120;

    public int ObjNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(onClick);
    }

    private void onClick()
    {
        if (checkPoints.childCount > 0)
        {
            for (int i = 0; i < checkPoints.childCount; i++)
            {
                Destroy(checkPoints.GetChild(i).gameObject);
            }
        }

        ScoreText.GetComponent<Score>().enabled = false;
        Time.GetComponent<Timer>().enabled = false;
        Score.ScoreInt = 0;
        Timer.TimeFloat = GameTime;
        ScoreText.GetComponent<Score>().enabled = true;
        Time.GetComponent<Timer>().enabled = true;

        CreateObjs(ObjNum, checkPoints);
        Debug.Log("this is Button");
    } 

    private void CreateObjs(int ObjNum, Transform parent)
    {
        for (int i = 0; i < ObjNum; i++)
        {
            Instantiate(obj, new Vector3(Random.Range(-200f, 200f), Random.Range(0f, 50f), Random.Range(-200f, 200f)), Quaternion.Euler(0, Random.Range(0, 360f), 0), parent);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer.TimeFloat == 0)
        {
            Debug.Log("Game over. Your Score is " + Score.ScoreInt);
            ScoreText.GetComponent<Score>().enabled = false;
            Time.GetComponent<Timer>().enabled = false;
            if (checkPoints.childCount > 0)
            {
                for (int i = 0; i < checkPoints.childCount; i++)
                {
                    Destroy(checkPoints.GetChild(i).gameObject);
                }
            }
        }
    }
}
