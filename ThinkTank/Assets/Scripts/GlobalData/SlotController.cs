using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SlotController : MonoBehaviour
{
    #region singleton
    public static SlotController Instance;
    void Awake()    //this makes sure that there can only be one existance of it aka dont fuck with it
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
    #endregion

    public List<Item> SlotID = new List <Item>(99);


    private bool Found;

    public UnityEvent CheckItem;

    //when a new item is picked up

    //i should probably add something here for quest goal updating

    public void NewItem(Item Aquired)
    {

        Found = false;

        for (int F = 0; F < 99; F++)
        {
            if (SlotID[F] == Aquired)
            {
                SlotID[F].Amount++;
                Found = true;
                break;
            }
        }


        if (Found == false)
        {
            for (int S = 0; S < 99; S++)
            {
                if (SlotID[S] == null)
                {
                    SlotID[S] = Aquired;
                    break;
                }
            }
        }
        //trigger evaluate
        CheckItem.Invoke();
    }
}