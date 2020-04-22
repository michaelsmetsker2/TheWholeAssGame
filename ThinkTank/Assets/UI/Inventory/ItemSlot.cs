﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
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

    public void UpdateSlot()
    {

    }

    public void Select()
    {
        if (Empty == false)
        {

        }
    }
}
