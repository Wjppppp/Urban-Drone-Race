using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCity : MonoBehaviour
{
    public GameObject currentCity;
    public GameObject[] cityPrefabs;
    public string[] cityNames;
    private GameObject[] cityGameObjects;
    private string[] cityNameTexts;
    private int selectedIndex = 0;
    private int length;
    // Start is called before the first frame update
    void Start()
    {
        length = cityPrefabs.Length;
        cityGameObjects = new GameObject[length];
        cityNameTexts = new string[length];
        for (int i = 0; i < length; i++)
        {
            cityGameObjects[i] = GameObject.Instantiate(cityPrefabs[i], transform.position, transform.rotation);
            cityNameTexts[i] = cityNames[i];
        }
        UpdateCity();
    }
    void UpdateCity()
    {
        cityGameObjects[selectedIndex].transform.position = currentCity.transform.position;
        cityGameObjects[selectedIndex].transform.rotation = currentCity.transform.rotation;
        cityGameObjects[selectedIndex].SetActive(true);
        MiniMapCityName.cityName = cityNameTexts[selectedIndex];
        for (int i = 0; i < length; i++)
        {
            if (i != selectedIndex)
            {
                cityGameObjects[i].SetActive(false);
            }
        }
    }
    public void OnNextButtonClick()
    {
        selectedIndex++;
        selectedIndex %= length;
        UpdateCity();
    }
    public void OnPrevButtonClick()
    {
        selectedIndex--;
        if (selectedIndex == -1)
        {
            selectedIndex = length - 1;
        }
        UpdateCity();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
