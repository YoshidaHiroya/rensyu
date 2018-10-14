using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
	GameObject sphere;
	// Use this for initialization
	void Start () {
		sphere = GameObject.Find ("Sphere");
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 spherepos = sphere.transform.position;
		this.transform.position = new Vector3 (this.transform.position.x,spherepos.y,this.transform.position.z);
	}
}
