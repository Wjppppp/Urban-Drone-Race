using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    static private int scoreInt = 0;
    private string string_score;
    public Text text;

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
        string_score = scoreInt.ToString();
        text.text = "Score: " + string_score;
    }
}
