using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrologueManager : MonoBehaviour
{
    [SerializeField] SoundManager sound;
    Animator anim;

    private void Start()
    {
        sound = FindObjectOfType<SoundManager>();
        sound.NockNock();
    }

   
}
