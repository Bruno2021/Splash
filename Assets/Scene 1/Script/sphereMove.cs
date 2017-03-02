using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class moveplayer1 : MonoBehaviour {

	public int speed;


	void Start()
	{
		
	}

	void FixedUpdate () {
		float moveHoinzontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 mouvement = new Vector3 (moveHoinzontal, 0, moveVertical);
		GetComponent<Rigidbody>().AddForce (mouvement * speed);
		}
}
