using UnityEngine;
using System.Collections;

public class DestroyObjectAndAddPoint : MonoBehaviour {

	public GameObject Piece1; 
	public GameObject Piece2; 
	public GameObject Piece3; 
	public GameObject Piece4; 
	public GameObject Piece5; 
	public GameObject AudioObject; 

	void Start()
	{
		MyScore = 0; 
	}

	public int MyScore {get;private set;}

	void OnTriggerEnter2D(Collider2D collisionObject)
	{
		try
		{
			Destroy (collisionObject.gameObject); 

			MyScore++; 

			GameObject ejector = GameObject.Find("ejector"); 
			GameObject bucketTrigger = GameObject.Find("bucket_trigger"); 

			AudioSource source = bucketTrigger.GetComponent<AudioSource>(); 

			if(!source.isPlaying)
			{
				source.Stop(); 
			}
			source.Play(); 
			
			GameObject piece1 = (GameObject) Instantiate (Piece1);
			GameObject piece2 = (GameObject) Instantiate (Piece2);
			GameObject piece3 = (GameObject) Instantiate (Piece3);
			GameObject piece4 = (GameObject) Instantiate (Piece4);
			GameObject piece5 = (GameObject) Instantiate (Piece5);

			Rigidbody2D rigidPiece1 = piece1.GetComponent<Rigidbody2D> (); 
			Rigidbody2D rigidPiece2 = piece2.GetComponent<Rigidbody2D> ();
			Rigidbody2D rigidPiece3 = piece3.GetComponent<Rigidbody2D> ();
			Rigidbody2D rigidPiece4 = piece4.GetComponent<Rigidbody2D> ();
			Rigidbody2D rigidPiece5 = piece5.GetComponent<Rigidbody2D> ();

			piece1.transform.position = ejector.transform.position; 
			piece2.transform.position = ejector.transform.position; 
			piece3.transform.position = ejector.transform.position; 
			piece4.transform.position = ejector.transform.position; 
			piece5.transform.position = ejector.transform.position; 

			rigidPiece1.velocity = new Vector2 (-30, Random.Range(-5, 15)); 
			rigidPiece2.velocity = new Vector2 (-30, Random.Range(-5, 15));
			rigidPiece3.velocity = new Vector2 (-30, Random.Range(-5, 15));
			rigidPiece4.velocity = new Vector2 (-30, Random.Range(-5, 15));
			rigidPiece5.velocity = new Vector2 (-30, Random.Range(-5, 15));

		}
		catch(UnityException ex)
		{
			Debug.Log(ex.GetBaseException().Message); 
		}
	}
}
