using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tir : MonoBehaviour {

	public GameObject Projectile;
	public int Force; 
	public AudioClip SoundTir;
	void Start () {
		
	}

	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			GetComponent<AudioSource>().PlayOneShot (SoundTir);
			GameObject Bullet = Instantiate (Projectile, transform.position, Quaternion.identity) as GameObject;  // tir des boulettes
			Bullet.GetComponent<Rigidbody> ().velocity = transform.forward * Force;                               // donne une force au boulette
			Destroy(Bullet,2f);
		}
		
	}
}
