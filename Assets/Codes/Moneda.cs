using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moneda : MonoBehaviour
{

    public GeneradorMoneda gMonedas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gMonedas = FindObjectOfType<GeneradorMoneda>();

        Destroy(gameObject);

        gMonedas.AgregarMoneda();

        Debug.Log("Obt:" + gMonedas.monedasObtenidas);
    }
}
