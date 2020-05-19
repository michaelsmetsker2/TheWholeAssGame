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
        GameMenu.Instance.MenuUi.SetActive(false);
        CurrentItem.OnUse();
    }

    //maybe add swap method here?

    public void EndInteract()
    {
        UiSelected.Instance.Clear();
    }
}
