using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkBase : MonoBehaviour
{
    public DataBase Data;

    //maybe store in data?
    public int ConvPlace;

    public TalkBlock[] Blocks = new TalkBlock[1];


    public virtual void Initiate()
    {
        Debug.LogError("this should be overriten");
    }
}