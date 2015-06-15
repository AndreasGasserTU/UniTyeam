using UnityEngine;
using System.Collections;

public class EatEnemy : MonoBehaviour {

	public GameObject[] enemies;
	public int points;
	string msg = "";
	public float mytime;
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

			points--;
			if(points <= 0) {
				points = 0;
				GameObject.FindGameObjectWithTag ("Player").GetComponent<Movement>().playerdead = true;
				msg = "Game Over! Time: " + mytime.ToString("0.00");
			}
			Destroy (col.gameObject);
		}
		if (col.gameObject.tag == "Life") {
			points++;
			Destroy (col.gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		points = 5;
		mytime = 0;
	}
	
	// Update is called once per frame  ---- Application.LoadLevel (0);  
	void Update () {
	
	}

	private void OnGUI() {
		GUI.Label (new Rect (Screen.width/2 - 34, Screen.height/2 - 10, 100, 100), msg);
		if (GameObject.FindGameObjectWithTag ("Player").GetComponent<Movement> ().playerdead) {
			if(GUI.Button(new Rect (Screen.width/2 - 50, Screen.height/2 + 30, 100, 30), "Play Again!")){
				Application.LoadLevel (0);  
			}
		}
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

	void FixedUpdate() {
		if(points > 0)
			mytime += Time.deltaTime;
	}
}
