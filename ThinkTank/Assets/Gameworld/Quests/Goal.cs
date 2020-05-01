using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
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
