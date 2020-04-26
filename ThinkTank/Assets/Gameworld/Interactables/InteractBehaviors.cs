using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractBehaviors : MonoBehaviour
{

    public TalkTo TalkTo;

    public void Actions(int Type)
    {
        TalkTo.Initiate();
    }
}
