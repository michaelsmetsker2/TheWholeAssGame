using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{

    public int PressId = 0;

    public void ResetPress()
    {
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