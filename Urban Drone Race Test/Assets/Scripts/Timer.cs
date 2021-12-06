using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    static private float TotalTime = 120;
    private float IntervalTime = 1.0f;
    public Text CoutDownText;

    static public float TimeFloat
    {
        get
        {
            return TotalTime;
        }
        set
        {
            TotalTime = value;
        }
    }

    void Start()
    {
        CoutDownText.text = string.Format("Time Left: {0:D2}:{1:D2}", (int)TotalTime / 60, (int)TotalTime % 60);
        //StartCoroutine(CountDown());
    }
    //private IEnumerable CountDown()
    //{
    //    while (TotalTime > 0)
    //    {
    //        yield return new WaitForSeconds(1.0f);
    //        TotalTime--;
    //        CoutDownText.text = string.Format("{0:D2}:{1:D2}", (int)TotalTime / 60, (int)TotalTime % 60);
    //    }
    //}
    void Update()
    {
        if (TotalTime > 0)
        {
            IntervalTime -= Time.deltaTime;
            if (IntervalTime <= 0)
            {
                IntervalTime = 1.0f;
                TotalTime--;
                CoutDownText.text = string.Format("Time Left: {0:D2}:{1:D2}", (int)TotalTime / 60, (int)TotalTime % 60);
            }
        }
    }
}
