using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ListManager : MonoBehaviour
{
    public TMP_Text[] ObjectList;
    public Toggle[] toggles;
    int ListIndex;

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
    }

    void CompleteList()
    {
        if (ListIndex == ObjectList.Length)
        {
            SceneManager.LoadScene("Final");
        }
    }
}
