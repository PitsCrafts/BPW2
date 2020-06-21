using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour
{
    public GameObject ForrestDay;
    public GameObject LightDay;
    public bool Day;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Pressed left click.");
            if (Day == true)
            {
                ForrestDay.SetActive(false);
                LightDay.SetActive(false);
                Day = false;
            }
            else
            {
                ForrestDay.SetActive(true);
                LightDay.SetActive(true);
                Day = true;
            }
        }
    }
}
