using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerGauche2 : MonoBehaviour {

	public float Vitesse = 15f;

	void Update()
	{
		if (Input.GetKey (KeyCode.R)) 
		{
			transform.Translate (Vector2.up * Vitesse * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.F)) 
		{
			transform.Translate (-Vector2.up * Vitesse * Time.deltaTime);
		}
	}
}
