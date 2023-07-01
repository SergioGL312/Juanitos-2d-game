using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImagenGanadora : MonoBehaviour
{
    public GeneradorMoneda generadorMoneda;

    private void Start()
    {
        generadorMoneda = FindObjectOfType<GeneradorMoneda>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == generadorMoneda.juanito)
        {
            generadorMoneda.Ganar();
        }
    }
}
