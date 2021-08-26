using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demarage : MonoBehaviour {

	// Use this for initialization
	void Start () {

		//Freeze time to wait for the player to press play 
		Time.timeScale = 0;
		//Get a reference to the Rigidbody2D component 
		//rb2d = GetComponent<Rigidbody2D>();


		//Set the initial velocity of our bird 
		//rb2d.velocity = vector2.right *speed* Time.deltaTime;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
