using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniMapCityName : MonoBehaviour
{
    static private string cityIndex;
    public Text cityText;
    static public string cityName
    {
        get
        {
            return cityIndex;
        }
        set
        {
            cityIndex = value;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cityText.text = cityName;
    }
}
