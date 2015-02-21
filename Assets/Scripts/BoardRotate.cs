using UnityEngine;
using System.Collections;

public class BoardRotate : MonoBehaviour {
	
	public float speed;

	void Update () {
		transform.Rotate (0, Input.GetAxis ("Horizontal") * speed * Time.deltaTime, 0, Space.Self);
	}
}