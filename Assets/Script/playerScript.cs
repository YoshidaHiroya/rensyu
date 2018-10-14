using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playerScript : MonoBehaviour {
	Rigidbody rb;
	public float force;
	public float speed;
	Text text;
	GameObject gameover;
	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody> ();
		gameover = GameObject.Find ("Gameover");
		text = this.gameover.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("right")) {
			rb.AddForce (new Vector2(force,0.0f));
		}
			
		if (Input.GetKeyDown ("left")) {
			rb.AddForce (new Vector2(-force,0.0f));
		}
		if(this.transform.position.x>4.3f||this.transform.position.x<-5.29f||this.transform.position.y<-3.0f){
			text.text="GAME OVER!";
		}
	}
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag=="yuka"){
		Debug.Log("あたり!");
		rb.velocity = new Vector3(0, speed,0);
		}
	}
			
}
