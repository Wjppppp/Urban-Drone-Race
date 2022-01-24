using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDrone : MonoBehaviour
{
    public GameObject currentDrone;
    public GameObject[] dronePrefabs;
    private GameObject[] droneGameObjects;
    private int selectedIndex = 0;
    private int length;
    // Start is called before the first frame update
    void Start()
    {
        length = dronePrefabs.Length;
        droneGameObjects = new GameObject[length];
        for (int i = 0; i < length; i++)
        {
            droneGameObjects[i] = GameObject.Instantiate(dronePrefabs[i], transform.position, transform.rotation);
         }
        UpdateDrone();
    }
    void UpdateDrone()
    {
        droneGameObjects[selectedIndex].transform.position = currentDrone.transform.position;
        droneGameObjects[selectedIndex].transform.rotation = currentDrone.transform.rotation;
        droneGameObjects[selectedIndex].SetActive(true);
        for(int i = 0; i < length; i++)
        {
            if(i != selectedIndex)
            {
                droneGameObjects[i].SetActive(false);
            }
        }
    }
    public void OnNextButtonClick()
    {
        selectedIndex++;
        selectedIndex %= length;
        UpdateDrone();
    }
    public void OnPrevButtonClick()
    {
        selectedIndex--;
        if(selectedIndex == -1)
        {
            selectedIndex = length - 1;
        }
        UpdateDrone();
    }
    // Update is called once per frame
    void Update()
    {
        droneGameObjects[selectedIndex].transform.position = currentDrone.transform.position;
        droneGameObjects[selectedIndex].transform.rotation = currentDrone.transform.rotation;
    }
}
