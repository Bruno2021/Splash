using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMenu : MonoBehaviour {

	public void Load_scene()
	{
		Application.LoadLevel ("Scene1"); //charge le niveau
	}

	public void Load_option()
	{
		Application.LoadLevel ("SceneOption");
	}

	//public  GameObject SphereGameObject ;

	//bool sphere = true;

	//public void SphereEnable(){
		//sphere = !sphere;
	//}

	//void Udapte(){
		//if (sphere == true) {
		//	SphereGameObject.SetActive (true);
		//} 
		//else {
		//	SphereGameObject.SetActive (false);
	//	}
	//}

	public void Quit_game()
	{
		Application.Quit();
	}
}
