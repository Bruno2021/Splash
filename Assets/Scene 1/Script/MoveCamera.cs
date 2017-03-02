﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

	public CharacterController Player;
	public GameObject player;
	private Vector3 offset;


	void Start () {
		offset = transform.position;
	}
	

	void LateUpdate () {
		transform.position = Player.transform.position + offset;
	}
}
