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
    public GameObject btnGroup;
    public GameObject gameoverObject;
    public int GameTime = 120;
    public int ObjNum = 0;

    public int maxHealth = 100; ///
    //public int currentHealth; ///
    public HealthBar healthBar; ///

    // Start is called before the first frame update
    void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(onClick);
        healthBar.gameObject.SetActive(false);
        gameoverObject.SetActive(false);
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
        
        healthBar.gameObject.SetActive(true);
        btnGroup.SetActive(false);
        ScoreText.GetComponent<Score>().enabled = false;
        Time.GetComponent<Timer>().enabled = false;
        gameoverObject.SetActive(false);
        Score.ScoreInt = 0;
        Timer.TimeFloat = GameTime;
        ScoreText.GetComponent<Score>().enabled = true;
        Time.GetComponent<Timer>().enabled = true;
        Time.gameObject.SetActive(true);
        ScoreText.gameObject.SetActive(true);


        CreateObjs(obj1, ObjNum, checkPoints);
        CreateObjs(obj0, ObjNum/2, checkPoints);
        CreateObjs(obj2, ObjNum/10, checkPoints);
        //Debug.Log("this is Button");

        DroneHealth.healthNum = maxHealth; ///
        healthBar.SetMaxHealth(maxHealth); ///
        healthBar.SetHealth(DroneHealth.healthNum);
    }
    public void OnTourClick()
    {
        Timer.TimeFloat = GameTime;
        DroneHealth.healthNum = 10000;
        ScoreText.GetComponent<Score>().enabled = false;
        Time.GetComponent<Timer>().enabled = false;
        btnGroup.SetActive(true);
        healthBar.gameObject.SetActive(false);
        Time.gameObject.SetActive(false);
        ScoreText.gameObject.SetActive(false);
        gameoverObject.SetActive(false);
        if (checkPoints.childCount > 0)
        {
            for (int i = 0; i < checkPoints.childCount; i++)
            {
                Destroy(checkPoints.GetChild(i).gameObject);
            }
        }
    }
    private Vector3 findCoord()
    {
        float x, y, z;
        x = Random.Range(-400f, 400f);//Secne Size
        y = Random.Range(0f, 80f);
        z = Random.Range(-400f, 400f);
        int radius = 2;
        while (true)
        {
            Collider[] cols = Physics.OverlapSphere(new Vector3(x, y, z), radius);
            //Debug.Log("There are"+cols.Length+"buildings around"+x+y+z);
            if (cols.Length == 0)
            {
                return new Vector3(x, y, z);
            }
            x = Random.Range(-400f, 400f);//Secne Size
            y = Random.Range(0f, 80f);
            z = Random.Range(-400f, 400f);
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
        //Debug.Log(parent.childCount);
        foreach(Transform tran in parent.GetComponentsInChildren<Transform>())
        {
            tran.gameObject.layer = 7;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer.TimeFloat == 0 || DroneHealth.healthNum == 0)//Game Over
        {
            Debug.Log("Game over. Your Score is " + Score.ScoreInt);
            ScoreText.GetComponent<Score>().enabled = false;
            Time.GetComponent<Timer>().enabled = false;
            btnGroup.SetActive(true);
            healthBar.gameObject.SetActive(false);
            Time.gameObject.SetActive(false);
            ScoreText.gameObject.SetActive(false);
            gameoverObject.SetActive(true);
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
