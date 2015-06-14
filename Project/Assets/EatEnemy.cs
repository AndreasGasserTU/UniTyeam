using UnityEngine;
using System.Collections;

public class EatEnemy : MonoBehaviour {

	public GameObject[] enemies;
	public int points = 0;

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Enemy") {
			if((enemies = GameObject.FindGameObjectsWithTag ("Enemy")).Length <= 1)
			{
				Vector3 spawnPoint;
				spawnPoint.x = getRandomNumber() * 20;
				spawnPoint.y = getRandomNumber() * 10;
				spawnPoint.z = 0;
				Instantiate (enemies [0], spawnPoint, Quaternion.identity);
			}
			if(transform.localScale.x <= 10)
			{
				transform.localScale += new Vector3(0.1F, 0.1F, 0);
			}
			points++;

			if(gameObject.GetComponent<Movement>().speed > 5 && (points % 5) == 0)
			{
				gameObject.GetComponent<Movement>().speed -= 0.5f;
			}
			Destroy (col.gameObject);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	int getRandomNumber()
	{
		int temp = 0; 
		while(temp == 0)
		{
			temp = Random.Range (1, -1);
		}

		return temp;
	}
}
