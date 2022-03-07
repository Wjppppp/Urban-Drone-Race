using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneHealth : MonoBehaviour
{
    public int maxHealth = 10000;
    static private int currentHealth = 0;

    public HealthBar healthBar;
    static public int healthNum
    {
        get
        {
            return currentHealth;
        }
        set
        {
            currentHealth = value;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }
        
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
    //void OnTriggerEnter(Collider col)
    void OnCollisionEnter(Collision collision)
    //void OnTriggerEnter(Collider col)
    {
        //Debug.Log(collision.gameObject.tag);
        //if (col.tag == "CitySimulatorMap")
        //if(collision.gameObject.name == "Cube")
        if(collision.gameObject)
        {
            //ScoreAndHealthSystem sh = (Player)ScoreAndHealthSystem.GetComponent("ScoreAndHealthSystem");
            //sh.currentHealth--;
            TakeDamage(5);
            //debug print or debug log to output
            
        }
    }


}
