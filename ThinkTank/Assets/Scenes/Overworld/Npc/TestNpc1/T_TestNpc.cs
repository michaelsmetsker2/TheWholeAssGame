using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T_TestNpc : TalkBase
{

    public Item ToGive;

    public override void Initiate()
    {
        switch (ConvPlace)
        {
            case 0: //just saying hi
                {
                    Interpreter.Instance.StartConvo(Blocks[ConvPlace]);
                    ConvPlace = 1;
                    break;
                }
            case 1: //you wouldnt waht an item would you?
                {
                    StartCoroutine(GetItem());
                    Interpreter.Instance.StartConvo(Blocks[ConvPlace]);
                    break;
                }
            case 2: //you sure you dont want an item?
                {
                    Interpreter.Instance.StartConvo(Blocks[ConvPlace]);
                    StartCoroutine(GetItem());
                    break;
                }
            case 3: //cool item huh
                {
                    Interpreter.Instance.StartConvo(Blocks[ConvPlace]);
                    break;
                }
        }
    }

    protected IEnumerator GetItem() //decide if you want an item
    {
        yield return new WaitUntil(() => Interpreter.Instance.Chosen != 0);

        if (Interpreter.Instance.Chosen == 1)
        {
            SlotController.Instance.NewItem(ToGive);
            ConvPlace = 3;
        }
        else
        {
            ConvPlace = 2;
        }

        Interpreter.Instance.Chosen = 0;
    }
}