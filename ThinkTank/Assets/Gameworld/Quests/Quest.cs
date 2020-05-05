using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "Quest", menuName = "Quest")]
public class Quest : ScriptableObject
{
    public string Name;

    public bool Completed = false;

    public int Progress = 0;

    public Goal[] Goals;

    public void Init()
    {
        Progress = 0;
        Completed = false;
        
        Goals[Progress].Init(this);
    }

    //triggered when a goal is complete
    public void NextGoal()
    {
        Progress++;

        if (Progress >= Goals.Length)
        {
            Complete();
        }
        else
        {
            Goals[Progress].Init(this);
        }
    }

    public void Complete()
    {
        //when all goals are finished

        Debug.Log("congrats on completing a quest");

        //do some reward shit here
        Completed = true;
    }
}