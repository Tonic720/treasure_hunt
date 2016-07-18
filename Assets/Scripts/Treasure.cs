using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Treasure : MonoBehaviour {
	bool didPlayerWin = false;

	public Text gameText;
	public Transform player;




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ((player.position - transform.position).magnitude < 5f) {
			gameText.text = "     You've found the Knight Press [space] to attack";
			if (Input.GetKey (KeyCode.Space)) {
				didPlayerWin = true;
			} else if (didPlayerWin) {
				gameText.text = "                   YOU WIN!!!";
			}
		}
	
	}
}
