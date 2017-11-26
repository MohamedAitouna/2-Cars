using UnityEngine;
using System.Collections;

public class MoveCar : MonoBehaviour {
	public float zero=1;
	public string condition;
	public Animator myAnimation;
	public int test = 0;
	public 	float horizontal =0;
	// Use this for initialization
	void Start () {
		myAnimation = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			horizontal = 1;
			if ( horizontal*zero>0) {

				if (transform.localPosition.x == zero * 0.75f) {
					myAnimation.SetInteger (condition, -1);
				} else {
					myAnimation.SetInteger(condition,1);
				}	
			}
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			horizontal = -1;
			if ( horizontal*zero>0) {
				if (transform.localPosition.x == zero * 0.75f) {
					myAnimation.SetInteger (condition, -1);
				} else {
					myAnimation.SetInteger(condition,1);
				}	
			}
		}
		for (int i = 0; i < Input.touchCount; i++) {
			Touch touch = Input.GetTouch (i);
			if (touch.phase == TouchPhase.Began) {
			  if(Camera.main.ScreenToWorldPoint(touch.position).x*zero>0)
				{
					if (transform.localPosition.x == zero * 0.75f) {
						myAnimation.SetInteger(condition,-1);
					} else {
						myAnimation.SetInteger(condition,1);
			
					}
		
				}
			}
		}
	}
}
