using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2dScript : MonoBehaviour {
	GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 spherepos = player.transform.position;
		this.transform.position = new Vector3 (this.transform.position.x,spherepos.y,this.transform.position.z);

	}
}
