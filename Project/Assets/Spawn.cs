using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour 
{
	public GameObject[] enemies;
	public GameObject player;
	public int amount;
	private Vector3 spawnPoint;
	public GameObject[] life;
	int counter;


	void Update () 
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		enemies = GameObject.FindGameObjectsWithTag ("Enemy");
		life = GameObject.FindGameObjectsWithTag ("Life");

		amount = enemies.Length;
		if (life.Length > 1) {
			life[1].GetComponent<Life>().abletodelete = true;
		}

		if (amount != 60) {
			InvokeRepeating ("spawning", 6, 10f);
		}
	}

	void spawning()
	{
		float playerx = player.transform.position.x;
		float playery = player.transform.position.y;
	
		if (playerx > 0) {
			if (getRandomNumber (20f - (playerx + 3f), -20f) > 0) {
				spawnPoint.x = getRandomNumber (playerx + 3f, 20f);
			} else {
				spawnPoint.x = getRandomNumber (playerx - 3f, -20f);
			}
		} else {
			if (getRandomNumber (-20f - (playerx - 3f), 20f) > 0) {
				spawnPoint.x = getRandomNumber (playerx + 3f, 20f);
			} else {
				spawnPoint.x = getRandomNumber (playerx - 3f, -20f);
			}
		}

		if (playery > 0) {
			if (getRandomNumber (10f - (playery + 3f), -10f) > 0) {
				spawnPoint.y = getRandomNumber(playery + 3f, 10f);
			} else {
				spawnPoint.y = getRandomNumber(playery - 3f, -10f);
			}
		} else {
			if (getRandomNumber (-10f - (playery - 3f), 10f) > 0) {
				spawnPoint.y = getRandomNumber (playery + 3f, 10f);
			} else {
				spawnPoint.y = getRandomNumber (playery - 3f, -10f);
			}
		}

		spawnPoint.z = 0;

		Instantiate (enemies [0], spawnPoint, Quaternion.identity);

		counter++;
		if ((counter % 4) == 0) {
			if (playerx > 0) {
				if (getRandomNumber (20f - (playerx + 3f), -20f) > 0) {
					spawnPoint.x = getRandomNumber (playerx + 3f, 20f);
				} else {
					spawnPoint.x = getRandomNumber (playerx - 3f, -20f);
				}
			} else {
				if (getRandomNumber (-20f - (playerx - 3f), 20f) > 0) {
					spawnPoint.x = getRandomNumber (playerx + 3f, 20f);
				} else {
					spawnPoint.x = getRandomNumber (playerx - 3f, -20f);
				}
			}
			
			if (playery > 0) {
				if (getRandomNumber (10f - (playery + 3f), -10f) > 0) {
					spawnPoint.y = getRandomNumber(playery + 3f, 10f);
				} else {
					spawnPoint.y = getRandomNumber(playery - 3f, -10f);
				}
			} else {
				if (getRandomNumber (-10f - (playery - 3f), 10f) > 0) {
					spawnPoint.y = getRandomNumber (playery + 3f, 10f);
				} else {
					spawnPoint.y = getRandomNumber (playery - 3f, -10f);
				}
			}
			spawnPoint.z = 0;
			Instantiate (life [0], spawnPoint, Quaternion.identity);
		}
	
		CancelInvoke ();
	}

	float getRandomNumber(float a, float b)
	{
		float temp;
		temp = Random.Range(a, b);
		return temp;
	}


}
