using UnityEngine;
using System.Collections;

public class FireProjectile : MonoBehaviour {

	public float force;
	public Rigidbody ball;

	public float repeatSpeed;

	public void shootingStart(){
		InvokeRepeating ("shoot", repeatSpeed, 2);
	}

	void shoot(){
		Rigidbody newPro = Instantiate (ball, transform.position + (transform.up/2), transform.rotation)
		as Rigidbody;
			
		newPro.AddForce (newPro.transform.up * force);
		GetComponent<AudioSource>().Play();
	}

	public void stop(){
		CancelInvoke();
	}
}
