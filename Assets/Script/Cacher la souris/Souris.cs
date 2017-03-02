using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Souris : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked; // la souris est bloqué et caché, elle ne peut être vu.
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) { //si on appuie sur la touche echape, la souris réaparait.
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
		}
	}
}
