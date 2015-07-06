using UnityEngine;
using System.Collections;

public class OnDestroyerEncounter : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collisionObject)
	{
		Destroy (collisionObject.gameObject); 
	}
}
