using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour 
{ 
	public float moveSpeed;

	Vector3 velocity;

	void Update ()
	{
		transform.Translate(velocity);
	}

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "RightBorder" 
		    || col.gameObject.tag == "LeftBorder") {

			//transform.position.x = -transform.position.x;
		}

		if (col.gameObject.tag == "BottomBorder" 
			|| col.gameObject.tag == "TopBorder") {
			//transform.position.y = -transform.position.y;
		}
	}

	void Start () {
		moveSpeed = 1f;
		velocity = new Vector3(Random.Range(-5f, 5f) * Time.deltaTime * moveSpeed, 
		                       Random.Range(-5f, 5f) * Time.deltaTime * moveSpeed, 0);
	}
}
