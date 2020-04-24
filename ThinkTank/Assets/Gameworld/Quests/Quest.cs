using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Quest", menuName = "Quest")]
public class Quest : ScriptableObject
{

    //the name of the quest
    public string Name;

    //if steps have to be completed in order
    public bool IsLinear;

    //0 == not started 1 == in progress 2 == completed
    public int Status;

    //add rewards heres
    // As a one of possible solutions your rewards could be just one serializable class object which would be configurable and will be parsed by the manager.
}