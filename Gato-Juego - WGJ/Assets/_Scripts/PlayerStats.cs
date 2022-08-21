using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class PlayerStats : MonoBehaviour
{
    public static int Vida = 3;
    public Image V1;
    public Image V2;
    public Image V3;

    public Sprite PerdidaVida;

    private void Update()
    {
        if (Vida == 2)
        {
            V1.sprite = PerdidaVida;
        }
        if (Vida == 1)
        {
            V2.sprite = PerdidaVida;
        }
        if (Vida == 0)
        {
            V3.sprite = PerdidaVida;
        }

    }

    IEnumerator Perdiste()
    {
        yield return new WaitForSeconds(5);
    }


    /*
    IEnumerator Tremble(Image image)
    {
        Vector3 aux = image.transform.position;
        for (int i = 0; i < 10; i++)
        {
            image.transform.localPosition += new Vector3(0.5f, 0, 0);
            yield return new WaitForSeconds(0.01f);
            image.transform.localPosition -= new Vector3(0.5f, 0, 0);
            yield return new WaitForSeconds(0.01f);
        }
        image.transform.position = aux;

    }
    */
}
