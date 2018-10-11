using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleScript : MonoBehaviour {


		public float accel = 100;

		private void Update()
		{
		var force = transform.forward*Input.GetAxisRaw("Horizontal") *accel;
		GetComponent<Rigidbody> ().AddForce (force,ForceMode.Impulse);
		}
	}

