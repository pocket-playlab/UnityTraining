using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
	public Transform Player;
	public float Speed = .5f;
	private Rigidbody2D rigidbodyComponent;
	private Vector2 CameraVector;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		CameraVector = ( Player.position - transform.position ) * Speed;
	}


	void FixedUpdate() {
		if (rigidbodyComponent == null) rigidbodyComponent = GetComponent<Rigidbody2D>();
		rigidbodyComponent.AddForce(CameraVector);
	}
}
