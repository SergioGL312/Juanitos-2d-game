using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GeneradorMoneda : MonoBehaviour
{
    public GameObject juanito, moneda;
    float tiempo = 0;
    public int monedasObtenidas = 0;
    public Text monedasText;
    public TMP_Text txtGanador;
    public GameObject Panel;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        generarMonedas();
    }

    void generarMonedas()
    {
        tiempo += Time.deltaTime;
        if (tiempo >= 3)
        {
            tiempo = 0;
            float x = UnityEngine.Random.Range(juanito.transform.position.x + 5, juanito.transform.position.x + 10);
            float y = UnityEngine.Random.Range(juanito.transform.position.y + 1, juanito.transform.position.y + 5);
            Instantiate(moneda, new Vector3(x, y, 0), new Quaternion());
        }
    }

    public void AgregarMoneda()
    {
        monedasObtenidas++;
        monedasText.text = "Monedas: " + monedasObtenidas.ToString();

        if (monedasObtenidas >= 10)
        {
            Ganar();
        }
    }
    public void Ganar()
    {
        Debug.Log("Haz ganado");
        Panel.SetActive(true);
        txtGanador.text = "Haz Ganado!!!";
        StartCoroutine(CambiarEscena("MenuPrincipal"));
    }

    public IEnumerator CambiarEscena(string nombreEscena)
    {
        yield return new WaitForSeconds(3);  // Espera por 3 segundos
        SceneManager.LoadScene(nombreEscena);
    }
}
