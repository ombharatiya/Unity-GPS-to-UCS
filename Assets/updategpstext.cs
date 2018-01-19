using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updategpstext : MonoBehaviour {
    public Text coordinates;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        coordinates.text = "LAT:" + GPS.Instance.latitude.ToString() + "  LON:" + GPS.Instance.longitude.ToString()+"\nGPSToUCS:" + GPStoUCS.GPSEncoder.GPSToUCS(GPS.Instance.latitude, GPS.Instance.longitude).ToString();
            }
}
