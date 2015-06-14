using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour 
{
	public GameObject[] enemies;
	public int amount;
	private Vector3 spawnPoint;

	void Update () 
	{
		enemies = GameObject.FindGameObjectsWithTag ("Enemy");
		amount = enemies.Length;

		if (amount != 15) {
			InvokeRepeating ("spawning", 2, 5f);
		}
	}

	void spawning()
	{
		spawnPoint.x = getRandomNumber() * 20;
		spawnPoint.y = getRandomNumber() * 10;
		//spawnPoint.x = Random.Range(-20, 20);
		//spawnPoint.y = Random.Range(-10, 10);
		spawnPoint.z = 0;

		//Instantiate (enemies [UnityEngine.Random.Range (0, enemies.Length - 1)], spawnPoint, Quaternion.identity);
		Instantiate (enemies [0], spawnPoint, Quaternion.identity);
		CancelInvoke ();
	}

	int getRandomNumber()
	{
		int temp = 0; 
		while(temp == 0)
		{
			temp = Random.Range(-1, 2);
		}
		print (temp + "");
		return temp;
	}
}
