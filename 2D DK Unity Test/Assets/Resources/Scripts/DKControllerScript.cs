using UnityEngine;
using System.Collections;

public class DKControllerScript : MonoBehaviour {

	public float moveDistance = 5.0f;
	bool moving = false;
	bool facingRight = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetAxis ("Horizontal") != 0 && moving == false) {
			moving = true;

				}

		else if (Input.GetAxis ("Vertical") != 0 && moving == false) {
			moving = true;

				}
	}
}
