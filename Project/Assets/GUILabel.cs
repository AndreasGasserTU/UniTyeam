using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class GUILabel : MonoBehaviour {
	GUIStyle description;
	GUIStyle title;
	// Use this for initialization
	private void OnGUI() {
		description = new GUIStyle ();
		description.normal.textColor = Color.black;
		title = new GUIStyle ();
		title.normal.textColor = Color.black;
		title.fontSize = 20;
		GUI.Label (new Rect (26, 65, 200, 100), "Life: " + GameObject.FindGameObjectWithTag ("Player").GetComponent<EatEnemy>().points + "    Time: " + GameObject.FindGameObjectWithTag ("Player").GetComponent<EatEnemy>().mytime.ToString("0.00"));
		GUI.Label (new Rect (16, 42, 2000, 100), "Use the arrow-keys to move and try to dodge the enemys (red dots). The lightblue dots are available for 3 secs and give you +1 life.", description);
		GUI.Label (new Rect (Screen.width / 2 - 280, 15, 2000, 100), "UniTyeam - Softwareentwicklung & Wissensmanagement SS2015", title);
	}
}
