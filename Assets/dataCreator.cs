using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class dataCreator : MonoBehaviour {

	public GameObject ball;
	public GameObject cube;
	public GameObject capsule;


	// Use this for initialization
	void Start () {
		Physics.gravity = new Vector3(0,0,0);
		float scale = 50;
		int number = 800;
		Random rnd = new Random ();
		for (int i = 0; i < number; i++) {
			Instantiate (ball, new Vector3 ((float)(101 + rnd.NextDouble()*scale), (float)(101 + rnd.NextDouble()*scale), (float)(101 + rnd.NextDouble()*scale)), Quaternion.identity);
			Instantiate(cube, new Vector3 ((float)(99 + rnd.NextDouble()*scale), (float)(99 + rnd.NextDouble()*scale), (float)(99 + rnd.NextDouble()*scale)), Quaternion.identity);
			Instantiate(capsule, new Vector3 ((float)(95 + rnd.NextDouble()*scale), (float)(70 + rnd.NextDouble()*scale), (float)(70 + rnd.NextDouble()*scale)), Quaternion.identity);
		}


	//	Instantiate (ball, transform.position, transform.rotation);

	
	}
	
	// Update is called once per frame
	void Update () {
			
	}
}
