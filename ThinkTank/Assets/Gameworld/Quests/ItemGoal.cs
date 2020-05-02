using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemGoal", menuName = "goal/ItemGoal")]
public class ItemGoal : Goal
{

    public Item Needed;

    public override void Init()
    {
        SlotController.Instance.CheckItem.AddListener(Evaluate);
    }


    public override void Evaluate()
    {
        if (SlotController.Instance.SlotID.Contains(Needed))
        {
            Debug.LogWarning("doshitheretomarrow");
        }
    }

    public override void Complete()
    {
        SlotController.Instance.CheckItem.RemoveListener(Evaluate);
    }
}
