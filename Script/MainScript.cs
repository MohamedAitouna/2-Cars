using UnityEngine;
using System.Collections;
using UnityEngine.UI;
 
public class MainScript : MonoBehaviour {

	private float shootCooldown = 5f; 
	public float cooldown=5f;
	public GameObject CarYallow, CarWhite;
	public Text Score;
	public Camera cam;
	public static float speed=0.0f;
	private int typeObjectYallaw = 0; 
	private int typeObjectWhite = 0;  
	private int r=0,g=0,b=0;
	// Use this for initialization
	void Start () {
		cam = GetComponent<Camera> ();
		Move.score = 0;
		Score.text ="0";
		Time.timeScale = 1.0f;
		speed = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		Score.text = "" + Move.score;
		if (speed < 5f) {
			speed += 0.01f;
			cooldown -= 0.0082f;
		}
			
		if (shootCooldown > 0) {
			shootCooldown -= Time.deltaTime;
		
		} else {
			typeObjectYallaw = Random.Range (0, 2);
			typeObjectWhite = Random.Range (0, 2);

			if(typeObjectWhite==0)
				Instantiate (CarWhite,new Vector3(-2.35f,5.5f,-4),Quaternion.identity);
			else
				Instantiate (CarWhite,new Vector3(-0.75f,5.5f,-4), Quaternion.identity);	
			
			if(typeObjectYallaw==0)
				Instantiate (CarYallow,new Vector3(2.35f,5.3f,-4), Quaternion.identity);
			else
				Instantiate (CarYallow,new Vector3(0.75f,5.3f,-4), Quaternion.identity);	
			
			shootCooldown = cooldown;
		}
	}
}
