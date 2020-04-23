using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item",menuName = "Item")]
public class Item : ScriptableObject
{
    public string Description;

    public Sprite IconS;
    public Sprite IconL;

    public int Amount;


}
