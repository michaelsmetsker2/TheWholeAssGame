using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Goal
{
    public bool Completed;

    public string Description;

    public int CurrentAmount;
    public int RequiredAmount;

    public void Evaluate()
    {
        //non complete this is gist
        if (CurrentAmount >= RequiredAmount)
        {
            Complete();
        }
    }   
    
    public virtual void Complete()
    {
        Completed = true;
    }
}
