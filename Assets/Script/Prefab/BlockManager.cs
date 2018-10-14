using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour {
	public int numberofBlock;
	public float minY;
	public float maxY;
	public float minX;
	public float maxX;
	public GameObject Block;
	Vector3 spawnpos= new Vector3(0,0,-1);
	// Use this for initialization
	void Start () {
		for (int i=0; i < numberofBlock; i++) {
			spawnpos.x = Random.Range (minX,maxX);
			spawnpos.y = Random.Range (minY,maxY);
			Instantiate (Block,spawnpos, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
