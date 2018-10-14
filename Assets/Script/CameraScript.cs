using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CameraScript : MonoBehaviour {
	GameObject sphere;
	GameObject high;
	Text text;
	// Use this for initialization
	void Start () {
		sphere = GameObject.Find ("Sphere");
		high = GameObject.Find ("High");
		text = this.high.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 spherepos = sphere.transform.position;
		this.transform.position = new Vector3 (this.transform.position.x,spherepos.y,this.transform.position.z);

		text.text = "高さ" + (spherepos.y).ToString()+"m";
	}
}
