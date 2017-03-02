using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour {

	void OnCallisionEnter(Collision Col)
	{
		Destroy(gameObject);
	}
}
