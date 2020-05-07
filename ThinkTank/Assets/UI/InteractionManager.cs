using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attached to the interactmenu ui object, values are changed when buttons are pressed
public class InteractionManager : MonoBehaviour
{
    public int PressId = 0;

    public static InteractionManager Instance;

    public void Awake()
    {
        Instance = this;
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