using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteract : MonoBehaviour
{
    private int CalledFrom;
    public void StartInteract(int SlotId)
    {

        CalledFrom = SlotId;
    }    
}
