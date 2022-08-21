using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistractionSound : MonoBehaviour
{
    private SoundManager sound;

    private void Awake()
    {
        sound = FindObjectOfType<SoundManager>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            sound.Maullido();
        }
    }
}
