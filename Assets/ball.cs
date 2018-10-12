using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ball : MonoBehaviour {
	public float speed = 25;
	public AudioClip sound;
	AudioSource audioSource; 
	// Use this for initialization
	void Start () {
		var force = new Vector3(0,0,1) * speed;
		this.GetComponent<Rigidbody> ().AddForce (force,ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision collision){
		if ( collision.gameObject.tag== ("batter" )) {
			audioSource = gameObject.GetComponent<AudioSource> ();
			audioSource.clip = sound;
			audioSource.Play ();
		
		}
	}

}
