using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soccorSript : MonoBehaviour {
	public int speed;
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody> ();
		rb.velocity = speed*new Vector3(1,1,0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag=="yuka"){
			
		rb = this.GetComponent<Rigidbody> ();
		rb.velocity = speed*new Vector3(1,1,0);
	}
		if (collision.gameObject.tag == "block") {
			Destroy (collision.gameObject);
		}

}
}