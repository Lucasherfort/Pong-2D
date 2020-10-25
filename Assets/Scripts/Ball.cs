using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public float time;
	public float Speed = 8f;

	void Start () 
	{
		if (GameObject.Find ("Eject").GetComponent<Direction> ().GoingDroite) 
		{
			GetComponent<Rigidbody2D> ().velocity = Vector2.right * Speed;
		}

		else
		{
			GetComponent<Rigidbody2D> ().velocity = -Vector2.right * Speed;
		}
	}

	void Update () 
	{
		time += Time.deltaTime;
		if (time > 10) 
		{
			Speed = 9f;
		}

		if (time > 20) 
		{
			Speed = 10f;
		}
		if (time > 30) 
		{
			Speed = 11f;
		}
		if (time > 40) 
		{
			Speed = 12f;
		}

		if (time > 50) 
		{
			Speed = 13f;
		}
		if (time > 60) 
		{
			Speed = 14f;
		}
	}

	float HitFactor(Vector2 BallPos, Vector2 RacketPos, float RacketHeight)
	{
		return (BallPos.y - RacketPos.y) / RacketHeight;
	}

	void OnCollisionEnter2D(Collision2D Col)
	{
		if (Col.gameObject.name == "RacketGauche1") 
		{
			float y = HitFactor (transform.position, Col.transform.position, Col.collider.bounds.size.y);
			Vector2 Dir = new Vector2 (1, y).normalized;
			GetComponent<Rigidbody2D> ().velocity = Dir * Speed;
		}
		if (Col.gameObject.name == "RacketGauche2") 
		{
			float y = HitFactor (transform.position, Col.transform.position, Col.collider.bounds.size.y);
			Vector2 Dir = new Vector2 (1, y).normalized;
			GetComponent<Rigidbody2D> ().velocity = Dir * Speed;
		}
		if (Col.gameObject.name == "RacketGauche2" && transform.position.x < -4.11f) 
		{
			float y = HitFactor (transform.position, Col.transform.position, Col.collider.bounds.size.y);
			Vector2 Dir = new Vector2 (-1, y).normalized;
			GetComponent<Rigidbody2D> ().velocity = Dir * Speed;
		}

		if (Col.gameObject.name == "RacketDroite1") 
		{
			float y = HitFactor (transform.position, Col.transform.position, Col.collider.bounds.size.y);
			Vector2 Dir = new Vector2 (-1, y).normalized;
			GetComponent<Rigidbody2D> ().velocity = Dir * Speed;
		}
		if (Col.gameObject.name == "RacketDroite2") 
		{
			float y = HitFactor (transform.position, Col.transform.position, Col.collider.bounds.size.y);
			Vector2 Dir = new Vector2 (-1, y).normalized;
			GetComponent<Rigidbody2D> ().velocity = Dir * Speed;
		}
		if (Col.gameObject.name == "RacketDroite2" && transform.position.x > 4.11f) 
		{
			float y = HitFactor (transform.position, Col.transform.position, Col.collider.bounds.size.y);
			Vector2 Dir = new Vector2 (1, y).normalized;
			GetComponent<Rigidbody2D> ().velocity = Dir * Speed;
		}
	}
}
