using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerDroitAI : MonoBehaviour
{
    public float Vitesse = 15f;
    GameObject Circleball;


    public void MoveUp()
    {
        transform.Translate(Vector2.up * Vitesse * Time.deltaTime);
    }

    public void MoveDown()
    {
        transform.Translate(-Vector2.up * Vitesse * Time.deltaTime);
    }
}
