using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public GameObject obj0, obj1, obj2;
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

        CreateObjs(obj1, ObjNum, checkPoints);
        CreateObjs(obj0, ObjNum/2, checkPoints);
        CreateObjs(obj2, ObjNum/10, checkPoints);
        Debug.Log("this is Button");
    }

    private Vector3 findCoord()
    {
        float x, y, z;
        x = Random.Range(-200f, 200f);
        y = Random.Range(3f, 40f);
        z = Random.Range(-200f, 200f);
        int radius = 3;
        while (true)
        {
            Collider[] cols = Physics.OverlapSphere(new Vector3(x, y, z), radius);
            Debug.Log("There are"+cols.Length+"buildings around"+x+y+z);
            if (cols.Length == 0)
            {
                return new Vector3(x, y, z);
            }
            x = Random.Range(-200f, 200f);
            y = Random.Range(3f, 40f);
            z = Random.Range(-200f, 200f);
            cols = null;
        }       
        
    }
    //draw ball
    //private void OnDrawGizmos()
    //{
    //    if (checkPoints.childCount > 0)
    //    {
    //        for (int i = 0; i < checkPoints.childCount; i++)
    //        {
    //            Gizmos.DrawWireSphere(checkPoints.position, 3);
    //        }
    //    }
        
    //}
    public void CreateObjs(GameObject obj,int ObjNum, Transform parent)
    {
        
        Vector3 coord;
        for (int i = 0; i < ObjNum; i++)
        {
            coord = findCoord();
            Instantiate(obj, coord, Quaternion.Euler(0, Random.Range(0, 360f), 0), parent);
        }       
        Debug.Log(parent.childCount);
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
