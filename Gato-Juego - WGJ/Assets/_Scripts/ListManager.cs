using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ListManager : MonoBehaviour
{
    private SoundManager soundManager;
    public TMP_Text[] ObjectList;
    public Toggle[] toggles;
    int ListIndex;

    private void Start()
    {
        soundManager = FindObjectOfType<SoundManager>();
    }
    private void Update()
    {
        CompleteList();
        
    }

    public void ObjectGrabbed()
    {
        toggles[ListIndex].isOn = true;
    }
    public void ObjectAdded()
    {
        string aux = ObjectList[ListIndex].text;
        ObjectList[ListIndex].text = "<s>" + aux + "</s>";
        ListIndex++;
        soundManager.Tachado();
    }

    void CompleteList()
    {
        if (ListIndex == ObjectList.Length)
        {
            SceneManager.LoadScene("Final");
        }
    }
}
