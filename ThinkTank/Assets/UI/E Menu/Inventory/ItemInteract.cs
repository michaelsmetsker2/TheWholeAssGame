using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemInteract : MonoBehaviour
{
    public Item CurrentItem;

    public void StartInteract(Item Current)
    {
        CurrentItem = Current;
    }


    public void Use()
    {
        Debug.Log("hey nice job clicking use on this useless item dipshit");
    }

    //maybe add swap method here?

    public void EndInteract()
    {
        UiSelected.Instance.Clear();
    }
}
