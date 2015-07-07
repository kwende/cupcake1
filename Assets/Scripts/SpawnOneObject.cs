using UnityEngine;
using System.Collections;

public class SpawnOneObject : MonoBehaviour {

	private Vector3 _startPosition; 

	public float MoveSpeed; 

	public float MoveDistance; 

	public GameObject RandomGameObject; 

	private int _counter = 0; 

	private bool _goingRight = true; 

	// Use this for initialization
	void Start () {
		MoveSpeed = 1.0f; 
		MoveDistance = 4.0f; 

		_startPosition = transform.position; 

		GameObject myGameObject = Instantiate (RandomGameObject); 
		float scaler = Random.Range (.2f, .7f); 
		myGameObject.transform.localScale = new Vector3 (scaler, scaler, scaler);
		myGameObject.transform.position = transform.position; 
	}
	
	// Update is called once per frame
	void Update () {
		_counter++; 

		if (Random.value < .06)
		{
			GameObject myGameObject = Instantiate (RandomGameObject); 
			//float scaler = Random.Range (.5f, 1f); 
			//myGameObject.transform.localScale = new Vector3 (scaler, scaler, scaler);
			myGameObject.transform.position = transform.position; 
		}

		if (_counter % 10 == 0) {
			_goingRight = !_goingRight; 
		}

		if (_goingRight) {
			transform.position = new Vector3(transform.position.x + 1, 
			                                 transform.position.y,
			                                 transform.position.z); 
		} else {
			transform.position = new Vector3(transform.position.x - 1, 
			                                 transform.position.y,
			                                 transform.position.z); 
		}
	}
}
