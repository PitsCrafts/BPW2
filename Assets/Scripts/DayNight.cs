using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour
{
    public GameObject ForrestDay;
    public GameObject ForrestNight;
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
                ForrestNight.SetActive(true);
                LightDay.SetActive(false);
                Day = false;
            }
            else
            {
                ForrestDay.SetActive(true);
                ForrestNight.SetActive(false);
                LightDay.SetActive(true);
                Day = true;
            }
        }
    }
}
