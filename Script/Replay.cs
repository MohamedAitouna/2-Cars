using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour {
	private static int condition=0;

	// Use this for initialization
	void Start () {
		condition = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown ("space"))
		 SceneManager.LoadScene (0, LoadSceneMode.Single);
		for (int i = 0; i < Input.touchCount; i++) {
			Touch touch = Input.GetTouch (i);
			if (touch.phase == TouchPhase.Began && condition==0) {
				condition = 1;
				SceneManager.LoadScene (0, LoadSceneMode.Single);
			}
		}
	}
}
