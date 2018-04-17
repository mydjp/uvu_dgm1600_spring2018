// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class wolfHealth : MonoBehaviour {
// 	public int currentHealth;
// 	public int maxHealth = 3;
// 	public Transform SpawnPoint;
// 	public int points;

// 	// Use this for initialization
// 	void Start () {
// 		currentHealth = maxHealth;
		
// 	}
	
// 	// Update is called once per frame
// 	public void TakeDamage(int amount){
// 		currentHealth -= amount;
// 		if(currentHealth <= 0){
// 			//Keep score at zero
// 			currentHealth=0;
// 			print("wolf is Dead!");
// 			// add points to score for killing wolf
// 			scoreManager.AddPoints(points);
//             // Move wolf to spawn point for restart
// 			transform.posistion = spawnPoint.position;
// 			transform.rotation = spawnPoint.rotation;
// 			//Reset Wolf Health
// 			currentHealth = maxHealth;
// 		}
		
// 	}
// }
