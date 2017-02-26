using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLookWalk : MonoBehaviour {

	public Transform vrCamera;

	public float toggleAngle = 30.0f;

	public float speed = 0.5f;

	public bool moveForward;

	private CharacterController cc;



	// Use this for initialization
	void Start () {
		cc = GetComponent<CharacterController> ();

	}
	
	// Update is called once per frame
	void Update () {
		//if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f) {
		if(Input.GetButtonDown("Fire1")){
			moveForward = true;
		} 

		if (Input.GetButtonUp ("Fire1")) {
			moveForward = false;
		}


	//	moveForward = false;

		if (moveForward) {
			Vector3 forward = vrCamera.TransformDirection (Vector3.forward);

			cc.Move (forward * speed);

			//cc.SimpleMove (forward * speed);

		}
	}
}
