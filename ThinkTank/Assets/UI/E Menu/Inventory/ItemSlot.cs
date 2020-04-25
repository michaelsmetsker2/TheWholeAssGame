using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    public SlotController SlotController;

    public ItemInteract ItemMenu;
    public Image IconS;
    public Text AmountBox;

    //the slots number in the inventory
    public int SlotNumber;

    //if the slot is holding an item
    private bool Empty = true;

    private void OnEnable()
    {
        if (SlotController.SlotID[SlotNumber] != null)
        {
            Empty = false;

            //setting the icon
            IconS.gameObject.SetActive(true);
            IconS.sprite = SlotController.SlotID[SlotNumber].IconS;
            
            //setting the amount
            if (SlotController.Instance.SlotID[SlotNumber].Amount != 1)
            {
                AmountBox.text = "X" + SlotController.SlotID[SlotNumber].Amount;
            }
            else
            {
                AmountBox.text = null;
            }
        }
        else
        {
            Empty = true;
            IconS.gameObject.SetActive(false);
            AmountBox.text = null;
        }
    }

    //for changing the slots icons and shit whilst the menu is still open
    public void UpdateSlot()
    {
        //put stuff here
    }

    public void Select()
    {
        if (Empty == false)
        {
            UiSelected.Instance.SelectItem(SlotController.SlotID[SlotNumber]);
        }
    }
}
