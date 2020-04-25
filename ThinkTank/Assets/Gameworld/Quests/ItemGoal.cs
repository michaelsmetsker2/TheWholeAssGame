using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGoal : Goal
{
    public string ItemName;

    public ItemGoal(string ItemName, string Description, bool Completed, int CurrentAmount, int RequiredAmount)
    {
        this.ItemName = ItemName;
        this.Description = Description;
        this.Completed = Completed;
        this.CurrentAmount = CurrentAmount;
        this.RequiredAmount = RequiredAmount;
    }

    public override void Init()
    {
        base.Init();
        //hook up to new item
    }

    void ItemGet(Item Received)
    {
        if (Received.Name == this.ItemName)
        {
            this.CurrentAmount++;
            Evaluate();
        }
    }

}
