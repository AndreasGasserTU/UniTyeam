using UnityEngine;
using System.Collections;

public class Life : MonoBehaviour {
	public float lifetime;
	public bool abletodelete;
	public float textx;
	public float texty;
	// Use this for initialization
	void Start () {
		lifetime = 3f;
		abletodelete = false;
	}

	void FixedUpdate() {
		lifetime -= Time.deltaTime;
		if (lifetime < 0) {
			lifetime = 0;
			if(abletodelete)
				Destroy (gameObject);
		}
	}

	void OnGUI(){
	//	GUI.Label (new Rect (Screen.width/2 + transform.position.x - 40, Screen.height/2 + 10 + transform.position.y, 200, 30), "+1 Life: " + lifetime.ToString("0.00"));
	}

}
