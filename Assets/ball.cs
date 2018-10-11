using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {
	public float speed = 25;
	// Use this for initialization
	void Start () {
		var force = new Vector3(0,0,1) * speed;
		this.GetComponent<Rigidbody> ().AddForce (force,ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
