using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	
	public int MaxPoint = 10;
	public int MinPoint = 0;

	public GameObject Projectil;
	public GameObject Eject;

	private void Awake()
	{
		Cursor.visible = false;
	}

	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space) && !GameObject.FindGameObjectWithTag("Ball"))
		{
			Instantiate (Projectil, Eject.transform.position, Quaternion.identity);
			GameObject.FindGameObjectWithTag("Ball").GetComponent<Ball> ().time = 0;
		}
	}

	void OnGUI () 
	{
		if (GameObject.Find ("ScoreG").GetComponent<TextMesh> ().text == MaxPoint.ToString () || GameObject.Find ("ScoreD").GetComponent<TextMesh> ().text == MaxPoint.ToString ()) 
		{
			Cursor.visible = true;
			Destroy (GameObject.FindGameObjectWithTag ("Ball"));
			if (GUI.Button (new Rect (Screen.width / 2 - 100, Screen.height / 2 - 25, 200, 50), "REJOUER")) 
			{
				Cursor.visible = false;
				GameObject.Find ("ScoreG").GetComponent<TextMesh> ().text = MinPoint.ToString ();
				GameObject.Find ("WallVerticalGauche").GetComponent<WallGauche> ().Score = 0;
				GameObject.Find ("ScoreD").GetComponent<TextMesh> ().text = MinPoint.ToString ();
				GameObject.Find ("WallVerticalDroite").GetComponent<WallDroite> ().Score = 0;
			}

			if (GUI.Button (new Rect (Screen.width / 2 - 100, Screen.height / 2 + 25, 200, 50), "QUITTER")) 
			{
				SceneManager.LoadScene ("MainMenu");
			}
		} 
	}
}
