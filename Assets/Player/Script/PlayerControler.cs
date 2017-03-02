using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour {

	public int speed;
	public int Sensibilité;
	public int Jump;
	public int gravite;
	public int Runspeed;
	private Vector3 DirectionDeplacement = Vector3.zero;
	private CharacterController Player;
	private Animator Anim;

	void Start () {
		Player = GetComponent<CharacterController> ();
		Anim = GetComponent<Animator> ();
	}
	

	void Update () {
		DirectionDeplacement.z = Input.GetAxis ("Vertical");
		DirectionDeplacement.x = Input.GetAxis ("Horizontal");
		DirectionDeplacement = transform.TransformDirection (DirectionDeplacement);

		//Deplacement
		if (Input.GetKey (KeyCode.LeftShift)) {
			Player.Move (DirectionDeplacement * Runspeed * Time.deltaTime);
		} else {
			Player.Move (DirectionDeplacement * Time.deltaTime * speed);
		}
		transform.Rotate (0, Input.GetAxisRaw ("Mouse X") * Sensibilité, 0);  // Mouvement en fonction de la sensibilté de la souris

		//Saut seulement si il touche le sol
		if(Input.GetKeyDown(KeyCode.Space) & Player.isGrounded)
			{
				DirectionDeplacement.y = Jump;
				Anim.SetTrigger ("JumpForward");
			}

		//Gravité 
		if (!Player.isGrounded) {
			DirectionDeplacement.y -= gravite * Time.deltaTime;
		}

		// Animation
		if (Input.GetKey (KeyCode.Z) & !Input.GetKey(KeyCode.LeftShift)) {
			Anim.SetBool("Walk",true);
			Anim.SetBool ("Run", false);
		}

		if (Input.GetKey (KeyCode.Z) & Input.GetKey(KeyCode.LeftShift)) {
			Anim.SetBool("Walk",true);
			Anim.SetBool ("Run", true);
		}

			
		if (!Input.GetKey(KeyCode.Z)) {
			Anim.SetBool("Walk",false);
			Anim.SetBool ("Run", false);

		}



	}
}
