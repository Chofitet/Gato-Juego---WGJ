using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenManager : MonoBehaviour
{
    private void Awake()
    {
        if (SceneManager.GetActiveScene().name == "PasoDelDia")
        {
            StartCoroutine(Delay());
        }
    }

    public void EscenaPrologo()
    {
        SceneManager.LoadScene("Prologo");
    }

    public void EscenaJuego()
    {
        SceneManager.LoadScene("PasoDelDia");
        
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("escenario");
    }
}
