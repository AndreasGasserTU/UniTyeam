using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour 
{
	public float speed;
	public int life;
	public bool playerdead = false;
	void Update ()
	{
		if (!playerdead) {
			if (Input.GetKey(KeyCode.LeftArrow))
			{
				transform.position += Vector3.left * speed * Time.deltaTime;
			}
			if (Input.GetKey(KeyCode.RightArrow))
			{
				transform.position += Vector3.right * speed * Time.deltaTime;
			}
			if (Input.GetKey(KeyCode.UpArrow))
			{
				transform.position += Vector3.up * speed * Time.deltaTime;
			}
			if (Input.GetKey(KeyCode.DownArrow))
			{
				transform.position += Vector3.down * speed * Time.deltaTime;
			}
		}
	}
}
