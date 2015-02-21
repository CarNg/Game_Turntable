using UnityEngine;
using System.Collections;

public class FallScore : MonoBehaviour {

	public GameObject Falls;
	public GameObject Points;

	void OnTriggerEnter(Collider other){
		audio.Play ();
		Destroy(other.gameObject);
		Points.GetComponent<Points>().falls += 1;

		if (Points.GetComponent<Points>().falls == 1){
			Falls.GetComponent<TextMesh> ().text = "X";
		}
		else if (Points.GetComponent<Points>().falls == 2){
			Falls.GetComponent<TextMesh> ().text = "X X";
		}
		else if (Points.GetComponent<Points>().falls >= 3){
			Falls.GetComponent<TextMesh> ().text = "X X X";
		}
	}
}
