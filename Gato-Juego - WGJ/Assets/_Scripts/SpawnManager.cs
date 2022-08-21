using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static bool ActiveObject;
    public GameObject[] spots;
    public GameObject[] Objects;
    private SoundManager Sound;
    
    int SpotIndex;
    int ObjectIndex;

    private void Start()
    {
        Sound = FindObjectOfType<SoundManager>();
        InstantiateObject();
    }

    

    public void InstantiateObject()
    {
        if (SpotIndex >= spots.Length) SpotIndex = 0;
        if (ObjectIndex >= Objects.Length) ObjectIndex = 0;
        Sound.Maullido();

        GameObject.Instantiate(Objects[ObjectIndex], spots[SpotIndex].transform.position, Quaternion.identity);
        SpotIndex++;
        ObjectIndex++;

        ActiveObject = true;
    }


}
