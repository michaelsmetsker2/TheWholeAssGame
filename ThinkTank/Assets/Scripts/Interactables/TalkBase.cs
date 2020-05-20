using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkBase : MonoBehaviour
{
    public DataBase DataQUESTIONMARK;

    //maybe store in data?
    public int ConvPlace;

    public TalkBlock[] Blocks = new TalkBlock[1];

    public virtual void Initiate()
    {
        Interpreter.Instance.StartConvo(Blocks[ConvPlace]);
    }
}