using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogador : MonoBehaviour {
	public float pulo;
	public GameObject gameOver;
	public Transform sensorChao;
	public bool estanoChao;
	Rigidbody2D rb;
	bool Nochao;
	Animator anim;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.UpArrow) && estanoChao == true ) {	
			anim.SetBool ("Pulo", true);
			rb.velocity = new Vector2 (-10.03f, pulo);
		}
		if (gameOver.activeInHierarchy == true && Input.GetKeyDown(KeyCode.Return)) {
			SceneManager.LoadScene ("DinoGame");
			Time.timeScale = 1;
			MainScript.pontos = 0;
			anim.SetBool ("Morto", false);

		}
		estanoChao = Physics2D.Linecast(transform.position, 
			sensorChao.transform.position, 
			1 << LayerMask.NameToLayer("Chao"));
	}
	void OnCollisionEnter2D(Collision2D c){
		if (c.collider.tag == "Cacto") {
			anim.SetBool("Morto",true);
			gameOver.SetActive (true);
			StartCoroutine (Tempo ());

		
		}else if (c.collider.tag == "Chao") {
			anim.SetBool ("Pulo", false);
		}


	} 
	IEnumerator Tempo(){
		yield return new WaitForSeconds (0.2f);
		Time.timeScale = 0;

	}

}
