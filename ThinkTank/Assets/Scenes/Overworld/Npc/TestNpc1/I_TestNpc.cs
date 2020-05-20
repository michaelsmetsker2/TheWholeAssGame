using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class I_TestNpc : ItemBase
{
    public override void Action()
    {
        switch(Received)
        {
            case "aaaaaa":
                {
                    Debug.Log("detected the test banana");
                    break;
                }
            default:
                {
                    Debug.Log("fix this/ this dont do shit");
                    break;
                }
        }
        Time.timeScale = 1f;
    }
}
