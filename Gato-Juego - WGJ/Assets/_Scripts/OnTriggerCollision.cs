using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerCollision : MonoBehaviour
{
    private ListManager List;
    private SpawnManager spawn;

    private void Awake()
    {
        List = FindObjectOfType<ListManager>();
        spawn = FindObjectOfType<SpawnManager>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Object" && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("objeto agarrado");
            Destroy(other.gameObject);
            SpawnManager.ActiveObject = false;
            List.ObjectGrabbed();
        }

        if (other.gameObject.tag == "Cauldron" && Input.GetKeyDown(KeyCode.E) && SpawnManager.ActiveObject == false)
        {
            Debug.Log("objeto al caldero");
            List.ObjectAdded();
            spawn.InstantiateObject();
        }
    }

    
}
