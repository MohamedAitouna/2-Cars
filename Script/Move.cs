using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public Sprite circle,squar;
	public GameObject replay;
	public static int score=0;
	private int typeSprite = 0;
	private SpriteRenderer spriteRenderer; 
	// Use this for initialization
	void Start () {
		
		typeSprite = Random.Range (0, 2);
		spriteRenderer = GetComponent<SpriteRenderer>();
		if (typeSprite == 0)
		spriteRenderer.sprite = circle;
		else
		spriteRenderer.sprite = squar;
	}
	void OnTriggerEnter2D(Collider2D info){
		if (typeSprite == 0) {
			score++;
			Destroy (this.gameObject);
		}
		else {
			Destroy (info.gameObject);
			Instantiate (replay);
			Time.timeScale = 0.0f;
		}
	}
	// Update is called once per frame
	void FixedUpdate () {
		transform.position -= new Vector3 (0,0.5f+MainScript.speed,0)*Time.deltaTime;
	if (transform.position.y < -4.5) {
			if (typeSprite == 1)
				Destroy (this.gameObject);
			else
			{
				Instantiate (replay);
				Time.timeScale = 0.0f;
			}
		}

	}
}
