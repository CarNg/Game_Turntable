using UnityEngine;
using System.Collections;

public class Points : MonoBehaviour {

	public int points;
	public float falls;
	public GameObject StartLose;
	public GameObject Jack;

	void Start () {
		points = 0;
		falls = 0f;
	}
	
	void Update () {
		GetComponent<TextMesh>().text = points.ToString();

		if (falls == 1) {
			Jack.GetComponent<FireProjectile> ().repeatSpeed = 0.8f;		
		}
		else if (falls == 2) {
			Jack.GetComponent<FireProjectile> ().repeatSpeed = 0.5f;
		}
		else if (falls >= 3){
			StartLose.GetComponent<StartLose>().lost();
		}
	}
}
