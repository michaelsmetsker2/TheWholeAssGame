using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item
{
    public int Amount;

    public abstract Sprite GetIcon();

    public abstract bool IsStackable();
}

public class ItemIndex : MonoBehaviour
{

    public Sprite RequestIcon()
    {
        return null;
    }


}
