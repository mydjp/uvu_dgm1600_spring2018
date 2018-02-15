using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenAI : MonoBehaviour {
	public float movespeed;
	public Transform target;
	public Transform chickenPen;

	public int points = 10;

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerStay(Collider other)
	{
		if(other.gameObject.name == "Player"){
			Debug.Log("Player has entered chickens trigger");
			transform.LookAt(target);
			transform.Translate(Vector3.back*movespeed*Time.deltaTime);
		}
	}

	void OnCollisionEnter(Collision other){
		if(other.gameObject.name == "Player"){
			transform.position = chickenPen.position;
			transform.rotation = chickenPen.rotation;
		}	
	}
	
}
