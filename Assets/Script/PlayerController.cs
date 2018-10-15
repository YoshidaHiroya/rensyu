using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	Rigidbody rb;
	Animator animator;
	public int jumpforce;
	public int walkforce;
	int key;
	float maxwalkspeed;
	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody> ();
		animator = this.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {		
		if (Input.GetKeyDown ("space")) {
			this.animator.SetBool ("JumpTrigger",true);
			rb.AddForce (jumpforce * (this.transform.up));

		}
		if (Input.GetKeyDown ("right")) {
			key = 1;
			rb.AddForce (walkforce * (this.transform.right));
			transform.localScale=new Vector3 (key,1,1);

			this.animator.SetBool ("JumpTrigger",false);
		}
		if (Input.GetKeyDown ("left")) {
			key = -1;
			rb.AddForce(-walkforce*(this.transform.right));//Addforce(ベクトル)
			transform.localScale=new Vector3 (key,1,1);//反転

			this.animator.SetBool ("JumpTrigger",false);
		}
		//if((rb.velocity.x)>maxwalkspeed){
		//	rb.AddForce (key * walkforce * (transform.right));
		//}

	}
}
