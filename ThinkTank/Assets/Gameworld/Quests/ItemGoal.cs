using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemGoal", menuName = "goal/ItemGoal")]
public class ItemGoal : Goal
{

    public Item Needed;

    public override void Init(Quest Attached)
    {

        base.Init(Attached);

        Parent = Attached;

        SlotController.Instance.CheckItem.AddListener(Evaluate);

        //automatically triggers the first time
        Evaluate();
    }

    //triggers when a new item is aquired
    public override void Evaluate()
    {
        for (int I = 0; I < SlotController.Instance.SlotID.Length; I++)
        {
            if (SlotController.Instance.SlotID[I] == (Needed))
            {
                CurrentAmount = SlotController.Instance.SlotID[I].Amount;
                break;
            }
        }
        if (CurrentAmount >= RequiredAmount)
        {
            Complete();
        }
    }

    public override void Complete()
    {
        SlotController.Instance.CheckItem.RemoveListener(Evaluate);
        Completed = true;
        Parent.NextGoal();
    }
}
