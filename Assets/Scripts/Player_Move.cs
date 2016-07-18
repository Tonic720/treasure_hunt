using UnityEngine;
using System.Collections;

public class Player_Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0f, 0f);

		if (Input.GetKey (KeyCode.W)||Input.GetKey (KeyCode.UpArrow)) {
			GetComponent<Rigidbody2D> ().velocity += new Vector2 (0f, 500f) * Time.deltaTime;
		
			
		}
		if (Input.GetKey (KeyCode.S)||Input.GetKey (KeyCode.DownArrow)) {
			GetComponent<Rigidbody2D> ().velocity += new Vector2 (0f, -500f) * Time.deltaTime;


		}
		if (Input.GetKey (KeyCode.D)||Input.GetKey (KeyCode.RightArrow)) {
			GetComponent<Rigidbody2D> ().velocity += new Vector2 (500f, 0f) * Time.deltaTime;


		}
		if (Input.GetKey (KeyCode.A)||Input.GetKey (KeyCode.LeftArrow)) {
			GetComponent<Rigidbody2D> ().velocity += new Vector2 (-500f, 0f) * Time.deltaTime;


		}
		
	
	}
}
