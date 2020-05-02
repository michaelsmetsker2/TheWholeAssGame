using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : ScriptableObject
{
    public bool Completed;

    public string Description;

    public int CurrentAmount;
    public int RequiredAmount;

    public virtual void Init()
    {

    }

    public virtual void Evaluate()
    {

    }   
    
    public virtual void Complete()
    {
        Completed = true;
    }

    public virtual void GiveReward()
    {

    }
}