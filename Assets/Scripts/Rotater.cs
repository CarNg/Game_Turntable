using UnityEngine;
using System.Collections;

public class Rotater : MonoBehaviour {

	bool changeDirection = false;

	void Update () {
		if(transform.eulerAngles.z >= 225){
			changeDirection = true;
		}
		else if (transform.eulerAngles.z <= 125){
			changeDirection = false;
		}

		if (changeDirection) {
			transform.Rotate (0, 0, -0.5f);
		}
		else {
			transform.Rotate (0, 0, 0.5f);	
		}
	}
}
