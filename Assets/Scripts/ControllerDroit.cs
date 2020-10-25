using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerDroit : MonoBehaviour {

	public float Vitesse = 15f;

	void Update () 
	{
		{
			if (Input.GetKey (KeyCode.P)) 
			{
				transform.Translate (Vector2.up * Vitesse * Time.deltaTime);
			}

			if (Input.GetKey (KeyCode.M)) 
			{
				transform.Translate (-Vector2.up * Vitesse * Time.deltaTime);
			}
		}
	}
}
