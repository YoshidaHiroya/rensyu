using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dodleScript : MonoBehaviour {
	public float speed =10.0f;
	public float force =10.0f;
	AudioSource audiosource;
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody> ();
		audiosource = this.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("right")) {
			rb.AddForce (force,0.0f,0.0f);
		}
		if (Input.GetKeyDown("left")) {
			rb.AddForce (-force,0.0f,0.0f);
		}
	}
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag=="yuka"){
			audiosource.Play ();
			rb.velocity = new Vector3 (0.0f,speed,0.0f);
		}
	}
}
