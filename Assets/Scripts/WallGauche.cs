using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGauche : MonoBehaviour 
{
	public int Score = 0;
	public GameObject Projectil;
	public GameObject Eject;

	void OnTriggerEnter2D(Collider2D Col)
	{
		Eject.GetComponent<Direction> ().GoingDroite = true;
		Destroy (Col.gameObject);
		Score = Score + 1;
		GameObject.Find ("ScoreD").GetComponent<TextMesh> ().text = "" + Score;
		Instantiate (Projectil, Eject.transform.position, Quaternion.identity);
		GameObject.FindGameObjectWithTag("Ball").GetComponent<Ball> ().time = 0;
	}
	
}
