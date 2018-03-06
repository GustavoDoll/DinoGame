using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
	public GameObject floor;
	void Start(){
		Instantiate (floor, transform.position, transform.rotation);
		StartCoroutine (SpawnChao ());


	}
	IEnumerator SpawnChao(){
		yield return new WaitForSeconds (5.3f);
		Instantiate (floor, transform.position, transform.rotation);
		StartCoroutine (SpawnChao ());
	}
}
