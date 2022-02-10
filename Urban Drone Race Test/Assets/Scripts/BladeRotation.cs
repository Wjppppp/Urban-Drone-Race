using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeRotation : MonoBehaviour
{
    public float speed = 5000f;
    public string dir = "z";

    // Update is called once per frame
    void Update()
    {
        switch (dir)
        {
            case "z":
                this.transform.Rotate(Vector3.forward * Time.deltaTime * speed);
                break;
            case "x":
                this.transform.Rotate(Vector3.right * Time.deltaTime * speed);
                break;
            case "y":
                this.transform.Rotate(Vector3.up * Time.deltaTime * speed);
                break;
            default:
                this.transform.Rotate(Vector3.forward * Time.deltaTime * speed);
                break;
        }
        
    }
}
