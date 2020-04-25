using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Quest : MonoBehaviour
{
    public List<Goal> Goals;
    public string QuestName;
    public string Description;
    public int MoneyReward;
    public Item ItemReward;
    public bool Completed;

    private void Start()
    {
        Goals = new List<Goal>();
    }

    public void CheckGoals()
    {
        if (Goals.All(g => g.Completed))
        {
            Completed = true;
            GiveReward();
        }
    }

    void GiveReward()
    {
        if (ItemReward != null)
        {
            //give item
        }
    }
}
