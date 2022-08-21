using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerCollision : MonoBehaviour
{
    private ListManager List;
    private SpawnManager spawn;
    public Animator anim;

    public GameObject carta;
    public Transform Spawn;
    public GameObject CartaCanvas;

    private void Awake()
    {
        List = FindObjectOfType<ListManager>();
        spawn = FindObjectOfType<SpawnManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Object" )
        {
            Debug.Log("objeto agarrado");
            Destroy(other.gameObject);
            SpawnManager.ActiveObject = false;
            List.ObjectGrabbed();
        }

        if (other.gameObject.tag == "Cauldron" && SpawnManager.ActiveObject == false)
        {
            Debug.Log("objeto al caldero");
            List.ObjectAdded();
            spawn.InstantiateObject();
        }

        if (other.gameObject.tag == "Door" )
        {
            anim.SetBool("PuertaAbierta", true);
            StartCoroutine(Carta());    
        }

        if (other.gameObject.tag == "Carta" )
        {
            Destroy(other.gameObject);
            
            anim.SetBool("PuertaAbierta", false);
            StartCoroutine(Cartacanvas());
        }
    }

    IEnumerator Carta()
    {
        yield return new WaitForSeconds(3);
        GameObject.Instantiate(carta, Spawn.position, Quaternion.identity);
    }

    IEnumerator Cartacanvas()
    {
        yield return new WaitForSeconds(2);
        CartaCanvas.gameObject.SetActive(true);
    }



}
