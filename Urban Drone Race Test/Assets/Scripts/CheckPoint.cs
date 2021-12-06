using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{

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
        Destroy(gameObject);      

        if(other.tag == "Drone")
        {
            Score.ScoreInt += 1;
        }
        Debug.Log("Score: "+ Score.ScoreInt);

    }
    private void OnTriggerStay(Collider other)
    {

    }
    private void OnTriggerExit(Collider other)
    {
  
    }
}
