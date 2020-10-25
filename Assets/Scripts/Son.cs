using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Son : MonoBehaviour {

	public AudioClip Sound;

	void OnCollisionEnter2D(Collision2D Col)
	{
		GetComponent<AudioSource> ().PlayOneShot(Sound);
	}
}
