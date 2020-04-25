using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public string Description;
    public bool Completed;
    public int CurrentAmount;
    public int RequiredAmount;

    public virtual void Init()
    {
        // defualt init stuff
    }

    public void Evaluate()
    {
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
