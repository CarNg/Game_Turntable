using UnityEngine;
using System.Collections;

public class ScoreTrigger : MonoBehaviour {

	Light myLight;

	public int PointsToAdd;
	public GameObject PointsDisplay;

	void Start(){
		myLight = GetComponentInChildren<Light> ();
	}

	void OnTriggerEnter(Collider other){
		GetComponent<AudioSource>().Play ();
		Destroy(other.gameObject);
		PointsDisplay.GetComponent<Points> ().points = PointsDisplay.GetComponent<Points> ().points + PointsToAdd;

		if(myLight.enabled){
			myLight.enabled = !myLight.enabled;
			Invoke ("LightOpposite", 1);
		}
		else if(!myLight.enabled){
			myLight.enabled = true;
			Invoke ("LightOpposite", 1);
		}
	}
	
	void LightOpposite(){
		if(myLight.enabled){
			myLight.enabled = !myLight.enabled;
		}
		else if(!myLight.enabled){
			myLight.enabled = true;
		}
	}
}
