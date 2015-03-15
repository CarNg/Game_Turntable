using UnityEngine;
using System.Collections;

public class Game_Pause : MonoBehaviour {

	bool pause = false;
	public GameObject jack;
	public GameObject pauseScreen;

	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape) || Input.GetButtonDown ("Jump")) {
			if (pause){
				pauseScreen.SetActive (false);
				AudioListener.volume = 1;
				pause = false;
				Time.timeScale = 1;
				jack.GetComponent<Rotater>().enabled = true;
			}
			else if (!pause){
				pauseScreen.SetActive (true);
				AudioListener.volume = 0;
				pause = true;
				Time.timeScale = 0;
				jack.GetComponent<Rotater>().enabled = false;
			}
		}
	}
}
