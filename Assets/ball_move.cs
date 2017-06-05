﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_move : MonoBehaviour {

	public float speed;

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		
		Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

		rb.AddForce(movement * speed);
	}
}
