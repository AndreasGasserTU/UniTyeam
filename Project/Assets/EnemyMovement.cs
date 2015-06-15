using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour 
{ 

	public float moveSpeed;

	Vector3 velocity;

	void FixedUpdate ()
	{
		transform.Translate(velocity);
	}

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Border" ) {
		
			float x = Random.Range (0f, moveSpeed);
			float y = moveSpeed - x;

			if(transform.position.x > 1) {
				x = -x;
			}

			if(transform.position.y > 1) {
				y = -y;
			}
			//velocity = new Vector3(x * Time.deltaTime * moveSpeed, 
			 //                      y * Time.deltaTime * moveSpeed, 0);
			velocity = new Vector3(x*Time.deltaTime, y*Time.deltaTime, 0);
		}


	}

	void Start () {
		moveSpeed = 10f;
		float x = Random.Range (0f, moveSpeed);
		float y = moveSpeed - x;
		if (Random.Range (-1f, 1f) > 0) {
			x = -x;
		}
		if (Random.Range (-1f, 1f) > 0) {
			y = -y;
		}
		velocity = new Vector3(x*Time.deltaTime, y*Time.deltaTime, 0);
	}

}
