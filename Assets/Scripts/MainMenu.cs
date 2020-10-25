using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void Mode1vs1()
	{
		SceneManager.LoadScene ("1vs1");
	}

	public void Mode1vsAI()
	{
		SceneManager.LoadScene ("1vsAI");
	}

	public void Mode2vs2()
	{
		SceneManager.LoadScene ("2vs2");
	}


	public void QUITTER()
	{
		Application.Quit ();
	}
}
