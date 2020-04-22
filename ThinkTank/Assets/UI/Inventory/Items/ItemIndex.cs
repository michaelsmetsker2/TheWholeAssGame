using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item
{
    public int Amount;

    public Sprite IconS;
    public Sprite IconL;

    public abstract Sprite GetIcon();

    public abstract bool IsStackable();
}

public class ItemIndex : MonoBehaviour
{

    public Sprite[] SmallIcon1;
    public Sprite LargeIcon1;

    public Sprite RequestIcon()
    {
        return null;
    }


}
