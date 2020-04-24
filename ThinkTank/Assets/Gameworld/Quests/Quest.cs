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

    public Reward TQL;
}