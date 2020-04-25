using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestQuest : Quest
{
    private void Start()
    {
        QuestName = "TestQuest";
        Description = "This is a test for quests";

        Goals.Add(new ItemGoal("TestItem", "get a testitem", false, 0, 1));

        Goals.ForEach(g => g.Init());
    }

}
