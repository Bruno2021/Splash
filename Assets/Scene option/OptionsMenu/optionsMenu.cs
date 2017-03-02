using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optionsMenu : MonoBehaviour
{
	public string done;

	public void Button_Done()
	{
		Application.LoadLevel (done);
	}
}
