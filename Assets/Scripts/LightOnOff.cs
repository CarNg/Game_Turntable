using UnityEngine;
using System.Collections;

public class LightOnOff : MonoBehaviour {
 
	Light myLight;

	void Start(){
		myLight = GetComponentInChildren<Light>();
	}

	void OnCollisionEnter(){
		if(myLight.enabled){
			myLight.enabled = !myLight.enabled;
		}
		else if(!myLight.enabled){
			myLight.enabled = true;
		}
	}
}
