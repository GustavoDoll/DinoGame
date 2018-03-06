using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFloor : MonoBehaviour {
	public GameObject floor;
	Vector2 pos =  new Vector2(28.47f, -4.63f);
	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds (4.5f);
		Instantiate (floor, pos, transform.rotation);
		StartCoroutine (Start ());
	}
	
	// Update is called once per frame

}
