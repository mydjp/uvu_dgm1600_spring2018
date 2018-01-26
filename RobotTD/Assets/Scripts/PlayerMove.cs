using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	// Use this for initialization
	

		 public float moveSpeed;
		 public float turnSpeed;
		 public float jumpHeight;
		
	
	
	// Update is called once per frame
	void Update () {
				// transform.Translate(transX,transY,transZ);
		// transform.Rotate(rotX,rotY,rotZ);
		 var j = Input.GetAxis("Jump")* Time.deltaTime * jumpHeight;
		 var y = Input.GetAxis("Horizontal")* Time.deltaTime * turnSpeed;
		var z = Input.GetAxis("Vertical")* Time.deltaTime * turnSpeed;
		
		transform.Rotate(0,y,0);
		transform.Translate(0,0,z);
		transform.Translate(0,j,0);
	}
}
