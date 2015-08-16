using UnityEngine;
using System.Collections;

public class player_movement : MonoBehaviour {

	public float speed = 1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate(Vector2.left * speed * Time.deltaTime);    
		}
		else if (Input.GetKey (KeyCode.D)) {
			transform.Translate(Vector2.right * speed * Time.deltaTime);   
		}
	}
}
