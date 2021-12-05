using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    static private int scoreInt = 0;

    static public int ScoreInt
    {
        get
        {
            return scoreInt;
        }
        set
        {
            scoreInt = value;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
