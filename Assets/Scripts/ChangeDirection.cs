using UnityEngine;
using System.Collections;

public class ChangeDirection : MonoBehaviour {

	void OnTriggerExit(Collider other){
		if (other.tag == "Slider" && other.GetComponent<Slider>().changeDirection){
			other.GetComponent<Slider>().changeDirection = false;
		}
		else if (other.tag == "Slider" && !other.GetComponent<Slider>().changeDirection){
			other.GetComponent<Slider>().changeDirection = true;
		}
	}
}
