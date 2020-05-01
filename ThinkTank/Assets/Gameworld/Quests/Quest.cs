using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "Quest", menuName = "Quest")]
public class Quest : ScriptableObject
{
    public string Name;

    public bool Completed;

    public Goal fifi;

    public Goal[] Goals = new Goal[1];

    //reward here (derive thingy
}