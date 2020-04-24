using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{

    public Interactables Interactables;

    private int PressId = 0;

    public IEnumerator GetPress()
    {
        yield return new WaitUntil(() => PressId != 0);
        Interactables.DeterminePress(PressId);
        PressId = 0;
    }

    public void Talk()
    {
        PressId = 1;
    }
    public void Item()
    {
        PressId = 2;
    }
    public void Use()
    {
        PressId = 3;
    }
    public void Exit()
    {
        PressId = 4;
    }

}