using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody> ().velocity = vector2.up * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
