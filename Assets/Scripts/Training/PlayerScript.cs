﻿using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public Vector2 speed = new Vector2(50, 50);

	// Update is called once per frame
	void Update () {

		float inputX = Input.GetAxis ("Horizontal");
		//float inputY = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3( speed.x * inputX, speed.y * 0, 0);

		movement *= Time.deltaTime;

		transform.Translate (movement);
	}
}
