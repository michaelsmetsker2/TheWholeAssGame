using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotController : MonoBehaviour
{
    public Item[] SlotId = new Item[99];

    //if an existing instance of the item is already found in the inventory
    private bool Found = false;

    //when a new item is picked up
    public void NewItem(Item Aquired)
    {
        Found = false;

        for (int F = 0; F < 99; F++)
        {
            if (SlotId[F] == Aquired)
            {
                if (Aquired.IsStackable())
                {
                    Aquired.Amount++;
                }
                else
                {
                    //go bring up some dialogue that says hey you dont need more than one of these
                    Debug.LogError("dammit michael you forgot to put this in");
                }
                Found = true;
                break;
            }
        }

        if (Found == false)
        {
            for (int N = 0; N < 99; N++)
            {
                if (SlotId[N] == null)
                {
                    SlotId[N] = Aquired;
                    break;
                }
            }
        }
    }

    public void SwapItem()
    {
        //make sure to also swap item amounts
    }

}
