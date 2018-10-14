using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour {
	public GameObject Sphere;
	float T;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		T += Time.deltaTime;
		if (T > 1.0f) {
			GameObject go =	Instantiate (Sphere,transform.position, Quaternion.identity)as GameObject;//ObjectPitcherから球が発射される。GameObject go =	Instantiate (Sphere)as GameObject;とかいた場合はPitcherとは無関係に生成される。
			T = 0;
		}
	}
}
