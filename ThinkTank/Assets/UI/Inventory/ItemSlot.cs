using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    public ItemInteract ItemMenu;
    public SlotController SlotController;
    public Image IconS;
    public Text AmountBox;

    //the slots number in the inventory
    public int SlotNumber;

    //if the slot is holding an item
    private bool Empty = true;

    private void OnEnable()
    {
        if (SlotController.SlotId[SlotNumber] != null)
        {
            Empty = false;

            //setting the icon
            IconS.gameObject.SetActive(true);
            IconS.sprite = SlotController.SlotId[SlotNumber].IconS;
            
            //setting the amount
            if (SlotController.SlotId[SlotNumber].Amount != 1)
            {
                AmountBox.text = "X" + SlotController.SlotId[SlotNumber].Amount;
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
            ItemMenu.gameObject.SetActive(true);
            ItemMenu.StartInteract(SlotNumber);

            //now show big iccon
            
            //now show item desxription
        }
    }
}
