using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerCollision : MonoBehaviour
{
    private ListManager List;

    private void Awake()
    {
        List = FindObjectOfType<ListManager>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Object" && Input.GetKeyDown(KeyCode.Mouse1))
        {
            Debug.Log("objeto agarrado");
            Destroy(other.gameObject);
            SpawnManager.ActiveObject = false;
            List.ObjectGrabbed();

        }

        if (other.gameObject.tag == "Cauldron" && Input.GetKeyDown(KeyCode.Mouse1))
        {
            Debug.Log("objeto al caldero");
            List.ObjectAdded();
        }
    }
}
