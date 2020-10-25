using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerGauche : MonoBehaviour {

	public float Vitesse = 15f;

	void Update()
	{
		if (Input.GetKey (KeyCode.A)) 
		{
			transform.Translate (Vector2.up * Vitesse * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.Q)) 
		{
			transform.Translate (-Vector2.up * Vitesse * Time.deltaTime);
		}
	}
}
