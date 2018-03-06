using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour {
	public float forca_pulo;
	Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump") || Input.GetKeyDown(KeyCode.UpArrow)) {
			rb.velocity = new Vector2 (0.0f, forca_pulo) ;
		}
	}
}
