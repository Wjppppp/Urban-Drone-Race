using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public int CheckPointType = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {        
        if (other.tag == "Drone")
        {
            Destroy(gameObject);
            if (CheckPointType == 0)
            {
                Score.ScoreInt -= 5;
            }
            if (CheckPointType == 1)
            {
                Score.ScoreInt += 1;
            }
            if (CheckPointType == 2)
            {
                Score.ScoreInt += 10;
            }
        }
        Debug.Log("Score: "+ Score.ScoreInt);
    }
    private void OnTriggerStay(Collider other)
    {       
        Destroy(gameObject);    
    }
    private void OnTriggerExit(Collider other)
    {
  
    }
}
