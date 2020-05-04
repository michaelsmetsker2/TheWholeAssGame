using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : ScriptableObject
{

    public Quest Parent;

    [HideInInspector]
    public bool Completed = false;

    public string Description;

    public int CurrentAmount = 0;
    public int RequiredAmount;

    public virtual void Init(Quest Attached)
    {
        CurrentAmount = 0;
        Completed = false;
    }

    public virtual void Evaluate()
    {

    }   
    
    public virtual void Complete()
    {

    }
}