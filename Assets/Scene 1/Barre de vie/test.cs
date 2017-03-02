using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

    BarreLife BarreDeVie = new BarreLife();

    // Use this for initialization
    void Start () {

        BarreDeVie.max = 100;
        BarreDeVie.valeur = 100;


       
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.O))
        {
            BarreDeVie.valeur -= 10;
        }


		if (Input.GetKeyDown(KeyCode.P))
        {
            BarreDeVie.valeur += 10;
        }

        if (BarreDeVie.valeur == 0)
        {
            GetComponent<TextMesh>().text = "You are Dead !!!";
        }
        

    }
}
