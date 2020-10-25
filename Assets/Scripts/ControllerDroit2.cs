using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerDroit2 : MonoBehaviour {

	public float Vitesse = 15f;

	void Update () 
	{
		{
			if (Input.GetKey (KeyCode.U)) 
			{
				transform.Translate (Vector2.up * Vitesse * Time.deltaTime);
			}

			if (Input.GetKey (KeyCode.J)) 
			{
				transform.Translate (-Vector2.up * Vitesse * Time.deltaTime);
			}
		}
	}
}
