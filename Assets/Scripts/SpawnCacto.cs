using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCacto : MonoBehaviour {
	public GameObject[] cactos;
	int valor;
	// Use this for initialization
	IEnumerator Start () {
		valor = Random.Range (0,cactos.Length);
		yield return new WaitForSeconds (2.0f);
		Instantiate (cactos [valor], transform.position, transform.rotation);
		StartCoroutine (Start ());
	}
	
	// Update is called once per frame


}
