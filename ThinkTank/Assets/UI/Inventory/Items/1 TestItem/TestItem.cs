using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TestItem : Item
{

    public override Sprite GetIcon()
    {
        return null;
    }

    public override bool IsStackable()
    {
        return false;
    }
}
