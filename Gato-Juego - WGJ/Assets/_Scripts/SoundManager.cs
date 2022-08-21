using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] GameObject maullido;
    [SerializeField] GameObject tachado;
    [SerializeField] GameObject nockNock;
    [SerializeField] GameObject conversacion;
    [SerializeField] GameObject gasp;

    void NuevoSonido(GameObject prefabs, Vector3 posición, float duración, bool ModificarPitch = true)
    {

        GameObject obj = Instantiate(prefabs, posición, Quaternion.identity);
        if (ModificarPitch)
        {
            obj.GetComponent<AudioSource>().pitch *= 1 + Random.Range(-0.2f, 0.2f);
        }
        Destroy(obj, duración);

    }

    public void Maullido()
    {
        NuevoSonido(maullido, transform.position, 2f);
    }
    public void Tachado()
    {
        NuevoSonido(tachado, transform.position, 1f);
    }
    public void NockNock()
    {
        NuevoSonido(nockNock, transform.position, 1f);
    }
        public void Conversacion()
        {
            NuevoSonido(conversacion, transform.position, 6f);
        }
    public void Gasp()
    {
        NuevoSonido(gasp, transform.position, 6f);
    }
}
