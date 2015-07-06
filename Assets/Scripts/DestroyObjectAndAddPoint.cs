using UnityEngine;
using System.Collections;

public class DestroyObjectAndAddPoint : MonoBehaviour {

	void Start()
	{
		MyScore = 0; 
	}

	public int MyScore {get;private set;}

	void OnTriggerEnter2D(Collider2D collisionObject)
	{
		Destroy (collisionObject.gameObject); 

		MyScore++; 

		Debug.Log ("My score is " + MyScore.ToString ()); 
	}
}
