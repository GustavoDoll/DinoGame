using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour {
	public  float velocidade;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.left * velocidade * Time.deltaTime);
		if (transform.position.x < -30.0f) {
			Destroy (gameObject);
		}
	}
}
