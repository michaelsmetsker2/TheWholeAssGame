using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T_TestNpc : TalkBase
{
    public TalkBlock Welcome;


    public override void Initiate()
    {
        Interpreter.Instance.StartConvo(Welcome);

        Debug.Log("i can see strickland from here");
    }


}
