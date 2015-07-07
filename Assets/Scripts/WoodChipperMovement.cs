using UnityEngine;
using System.Collections;

public class WoodChipperMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float horizontalAxis = Input.GetAxis ("Horizontal")/2; 

		if (horizontalAxis < 0 && transform.position.x > -10 ||
		    horizontalAxis >= 0 && transform.position.x < 10) {
			transform.Translate (new Vector3 (horizontalAxis, 0, 0)); 
		}

		Debug.Log (transform.position); 
	}
}
