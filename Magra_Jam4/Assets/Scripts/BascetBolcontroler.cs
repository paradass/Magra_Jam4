using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BascetBolcontroler : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Ball")
        {
            Debug.Log("bitti oyun ð");
        }
    }
}