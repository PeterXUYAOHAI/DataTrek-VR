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
		float scale = 60;
		int number = 2000;
		Random rnd = new Random ();
		for (int i = 0; i < number; i++) {
			Instantiate (ball, new Vector3 ((float)(103 + rnd.NextDouble()*scale), (float)(103 + rnd.NextDouble()*scale), (float)(103 + rnd.NextDouble()*scale)), Quaternion.identity);
			Instantiate(cube, new Vector3 ((float)(60 + rnd.NextDouble()*scale), (float)(60 + rnd.NextDouble()*scale), (float)(97 + rnd.NextDouble()*scale)), Quaternion.identity);
			Instantiate(capsule, new Vector3 ((float)(93 + rnd.NextDouble()*scale), (float)(70 + rnd.NextDouble()*scale), (float)(70 + rnd.NextDouble()*scale)), Quaternion.identity);
		}


	//	Instantiate (ball, transform.position, transform.rotation);

	
	}
	
	// Update is called once per frame
	void Update () {
			
	}
}
