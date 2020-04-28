using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkBase : MonoBehaviour
{
    public virtual void Initiate()
    {
        Debug.LogError("this should be overriten");
    }
}