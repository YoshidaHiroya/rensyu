using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle2Script : MonoBehaviour {
	public float accel = 100;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var force = transform.forward*Input.GetAxisRaw("Vertical") *-accel;
		GetComponent<Rigidbody> ().AddForce (force,ForceMode.Impulse);
	}
}
