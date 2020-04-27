using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBase : MonoBehaviour
{
    public virtual void Initiate()
    {
        Debug.LogError("this should be overriden");
    }
}
