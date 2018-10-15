using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yaruoScript : MonoBehaviour {
	public int right;
	public int left;
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("right")) {
			transform.Translate(right, 0, 0);
			}	
		if (Input.GetKeyDown ("left")) {
			transform.Translate(-left, 0, 0);

		}	
	}
}
