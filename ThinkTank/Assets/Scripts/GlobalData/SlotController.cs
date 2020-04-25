using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public Item[] SlotID = new Item[99];

    private int LowestNull = 0;


    //when a new item is picked up

    //i should probably add something here for quest goal updating
    
    public void NewItem(Item Aquired)
    {

        Debug.LogError("IM TIRED MICHAEL FIX AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
        SlotID[0] = Aquired;
        /*
        LowestNull = -1;

        for (int F = 0; F < 99; F++)
        {

            if (SlotID[F] == null && LowestNull == -1)
            {
                LowestNull = F;
            }

            if (SlotID[F] == Aquired)
            {
                Aquired.Amount++;
                break;
            }

            if (F == 99)
            {
                SlotID[LowestNull] = Aquired;
                break;
            }
        }*/
    }
}