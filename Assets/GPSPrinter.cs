using UnityEngine;
using System.Collections;

public class GPSPrinter : MonoBehaviour
{
    LocationInfo locI = new LocationInfo();
    void Start()
    {
        this.GetComponent<TestLocationService>();
    }
    private void FixedUpdate()
    {
        if (Input.location.status == LocationServiceStatus.Running)
        {
            locI = Input.location.lastData;
            Debug.Log(Input.location.lastData);
        }
    }
    
    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 100, 100), $"L: {locI.latitude} | L: {locI.longitude}");
    }
}