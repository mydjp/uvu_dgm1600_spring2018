using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {
	public Rigidbody projecticle;
	public Transform shootPoint;
	public int shootSpeed;

	// Use this for initialization
	
		
	
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){
			
			Rigidbody clone;
			
			clone = (Rigidbody)Instantiate(projecticle, shootPoint.position, projecticle.rotation);

			clone.velocity = shootPoint.TransformDirection (Vector3.forward*shootSpeed*Time.deltaTime);
		}
		
	}
}
