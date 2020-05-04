using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class U_TestNpc : UseBase
{
    public Quest ToGive;

    public override void Initiate()
    {
        QuestController.Instance.StartQuest(ToGive);
        Time.timeScale = 1f;
    }
}
