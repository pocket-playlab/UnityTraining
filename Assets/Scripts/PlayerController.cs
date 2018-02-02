using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour {

	public float Speed = 1f;
	private Vector2 movement;
	private Rigidbody2D rigidbodyComponent;
	

	void Update() {
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");

		movement = new Vector2(
			inputX,
			inputY
		).normalized 
		* Mathf.Max( 
				Mathf.Abs( inputX ), 
				Mathf.Abs( inputY ) 
		) 
		* Speed;
	}

	void FixedUpdate() {
		if (rigidbodyComponent == null) rigidbodyComponent = GetComponent<Rigidbody2D>();
		rigidbodyComponent.velocity = movement;
	}
}
