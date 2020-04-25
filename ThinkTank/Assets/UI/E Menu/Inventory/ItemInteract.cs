using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemInteract : MonoBehaviour
{
    //public SelectedInfo SelectedInfo;


    private int CalledFrom;


    public void StartInteract(int SlotId)
    {
        CalledFrom = SlotId;
    }

    public void EndInteract()
    {
        //SelectedInfo.DisplayInfo(null);
        this.gameObject.SetActive(false);
    }
}
