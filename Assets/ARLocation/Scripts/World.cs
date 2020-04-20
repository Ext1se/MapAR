using ARLocation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class World : MonoBehaviour
{
    public ARLocationManager arLocationManager;
    public InputField latitude;
    public InputField longitude;
    public PlaceAtLocation gpsObject;

    //private ARLocationProvider locationProvider;

    void Start()
    {
        //locationProvider = ARLocationProvider.Instance;
        //locationProvider = arLocationManager.GetARLocationProvider();
        //latitude.text = "Latitude: " + locationProvider.CurrentLocation.latitude;
        //longitude.text = "Longitude: " + locationProvider.CurrentLocation.longitude;
        //Debug.Log("Hi: " + locationProvider.CurrentLocation.latitude);
    }
    void Update()
    {
        
    }

    public void GetMyLocation()
    {
        Debug.Log("Hi: " + arLocationManager.GetARLocationProvider().CurrentLocation.latitude);
        latitude.text = arLocationManager.GetARLocationProvider().CurrentLocation.latitude.ToString();
        longitude.text = arLocationManager.GetARLocationProvider().CurrentLocation.longitude.ToString();
        SetNewLocation(arLocationManager.GetARLocationProvider().CurrentLocation.latitude, arLocationManager.GetARLocationProvider().CurrentLocation.longitude);
    }

    public void SetNewLocation()
    {
        /*
        NumberStyles styles = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands |
               NumberStyles.AllowExponent; ;
        IFormatProvider provider = CultureInfo.CreateSpecificCulture("en-GB");
        Debug.Log("Lon = " + longitude.text);
        Debug.Log(latitude.text);
        string s1 = latitude.GetParsedText();
        string s2 = longitude.GetParsedText();
        Debug.Log(s1 + " " + s2);
        double z = Convert.ToDouble(s1.ToString().Trim());
        //double z = double.Parse(s1, CultureInfo.InvariantCulture);
        Debug.Log("z = " + z);
        */

        //double x = double.Parse(longitude.text.ToString());
        //SetNewLocation(Double.Parse(latitude.text, styles, provider), Double.Parse(longitude.text, styles, provider));
        SetNewLocation(Double.Parse(latitude.text), Double.Parse(longitude.text));
    }
    public void SetNewLocation(double latitude, double longitude)
    {
        gpsObject.LocationOptions.LocationInput.Location.Latitude = latitude;
        gpsObject.LocationOptions.LocationInput.Location.Longitude = longitude;
        Debug.Log("OK");
        gpsObject.Location.Longitude = longitude;
        gpsObject.Location.Longitude = latitude;
        gpsObject.Restart();
    }
}
