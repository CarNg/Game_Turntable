using UnityEngine;
using System.Collections;

public class Slider : MonoBehaviour {

	public bool changeDirection;

	void Update () {
		if (changeDirection) {
			transform.Translate(0.6f * Time.deltaTime, 0 , 0);	
		}
		else {
			transform.Translate(-0.6f * Time.deltaTime, 0 , 0);	
		}
	}
}
