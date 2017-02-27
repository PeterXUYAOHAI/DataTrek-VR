using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class dataCreator : MonoBehaviour {

	public GameObject ball;
	public GameObject cube;


	// Use this for initialization
	void Start () {
		Random rnd = new Random ();
		for (int i = 0; i < 100; i++) {
			Instantiate (ball, new Vector3 ((float)(101 + rnd.NextDouble()*5), (float)(101 + rnd.NextDouble()*5), (float)(101 + rnd.NextDouble()*5)), Quaternion.identity);
			Instantiate(cube, new Vector3 ((float)(99 + rnd.NextDouble()*5), (float)(99 + rnd.NextDouble()*5), (float)(99 + rnd.NextDouble()*5)), Quaternion.identity);
		}


	//	Instantiate (ball, transform.position, transform.rotation);

	
	}
	
	// Update is called once per frame
	void Update () {
			
	}
}
