﻿using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

	public int hp = 2;

	public bool isEnemy = true;

	public GameObject buttonSet;


	void Start(){
		buttonSet.SetActive (false);
	}

	void OnTriggerEnter2D (Collider2D collider) {



		ShotScript shot = collider.gameObject.GetComponent<ShotScript> ();

		if (shot != null) { 
			if (shot.isEnemyShot != isEnemy) {
				hp -= shot.damage;

				Destroy (shot.gameObject);

				if (hp <= 0) 
				{
//					SoundEffectHelper.Instance.Explosion(transform.position);
					SoundEffectHelper.Instance.MakeExplosionSound ();
					Destroy (gameObject);
					buttonSet.SetActive (true);

				}
			}
		}
	}
}