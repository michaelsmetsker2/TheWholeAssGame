using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Useless Item", menuName = "Item/Useless")]
public class UselessItem : Item
{
    //keep speaker as null
    public TalkBlock NoUse;

    public override void OnUse()
    {
        Interpreter.Instance.StartConvo(NoUse);
    }
}
