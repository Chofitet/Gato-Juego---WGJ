using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenManager : MonoBehaviour
{
    public void EscenaJuego()
    {
        SceneManager.LoadScene("escenario");
    }
}
