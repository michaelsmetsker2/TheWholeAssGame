using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class Item : ScriptableObject
{
    public string Name;

    [TextArea(10,15)]
    public string Description;

    public Sprite IconS;
    public Sprite IconL;

    public int Amount;

    public abstract void OnUse();

}
