using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestController : MonoBehaviour
{
    #region Instance
    public static QuestController Instance;
    void Awake()
    {
        Instance = this;
    }
    #endregion

    public Quest[] QuestStatus = new Quest[3];

    public void StartQuest(int QuestNumber)
    {
        QuestStatus[QuestNumber].Status = 1;

        Debug.Log("Display Quest Popup here");
    }
}
