using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(GPStoUCS.GPSEncoder.GPSToUCS(GPS.Instance.latitude, GPS.Instance.longitude));
	}
}
