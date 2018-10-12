using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class but : MonoBehaviour {
	
		

		public Vector3 angle;

		// Update関数
		void Update () {
		if (Input.GetKey("space")) {
			//angle変数(x,y,z)の数値にTime.deltaTimeを掛けて毎フレームごとに移動するようにする
			transform.Rotate (angle * Time.deltaTime*7);


		
		}
	}
}
