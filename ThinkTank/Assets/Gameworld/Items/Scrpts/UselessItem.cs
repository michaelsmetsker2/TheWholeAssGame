using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Useless Item", menuName = "Item/Useless")]
public class UselessItem : Item
{
    public override void OnUse()
    {
        Debug.Log("hey this doesnt do shit nut i havnt added a message to tell the player that");
        //dont do shit
    }
}
