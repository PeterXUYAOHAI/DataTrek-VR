using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLookWalk : MonoBehaviour {

	public Transform vrCamera;

	public float speed = 0.5f;

	public bool moveForward;

	private CharacterController cc;


	// Use this for initialization
	void Start () {
		cc = GetComponent<CharacterController> ();
	

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){
			moveForward = true;
		} 

		if (Input.GetButtonUp ("Fire1")) {
			moveForward = false;
		}



		if (moveForward) {
			Vector3 forward = vrCamera.TransformDirection (Vector3.forward);
			Vector3 move;	
			move.x = (float)((double)forward.x * (double)speed);
			move.y = (float)((double)forward.y * (double)speed);
			move.z = (float)((double)forward.z * (double)speed);
			Debug.Log (move.y);
			//cc.Move (forward * speed);
			cc.Move (move);
		}

	}
}
