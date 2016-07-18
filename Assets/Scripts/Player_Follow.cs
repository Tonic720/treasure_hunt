using UnityEngine;
using System.Collections;

public class Player_Follow : MonoBehaviour {
	
	public Vector3 offset;
	//public GameObject player;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Camera.main.transform.position = transform.position + offset;
	}
}
