using UnityEngine;
using System.Collections;

public class StartLose : MonoBehaviour {

	public GameObject table;
	public Texture lose;
	public GameObject points;
	public GameObject jack;
	public GameObject ball;

	bool startMenu;
	public bool loseMenu;
	
	void Start(){
		startMenu = true;
		loseMenu = false;
		table.GetComponent<BoardRotate>().enabled = false;
		table.GetComponent<AudioSource> ().enabled = false;
	}

	void Update () {
		if (Input.GetButtonDown ("Jump") && startMenu) {
			play();
		}
		else if (Input.GetKeyDown ("r") && loseMenu){
			Application.LoadLevel(Application.loadedLevel);
		}
	}

	void play(){
		jack.GetComponent<FireProjectile> ().shootingStart ();
		table.GetComponent<BoardRotate> ().enabled = true;
		table.GetComponent<AudioSource> ().enabled = true;
		gameObject.GetComponent<GUITexture> ().enabled = false;
		startMenu = false;
	}

	public void lost(){
		loseMenu = true;
		gameObject.GetComponent<GUIText>().text = points.GetComponent<Points>().points.ToString();
		jack.GetComponent<FireProjectile> ().stop ();
		table.GetComponent<BoardRotate> ().enabled = false;
		table.GetComponent<AudioSource> ().enabled = false;
		guiTexture.texture = lose;
		gameObject.GetComponent<GUITexture> ().enabled = true;
	}
}
