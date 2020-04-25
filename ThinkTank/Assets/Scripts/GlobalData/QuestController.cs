using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestController : MonoBehaviour
{
    public static QuestController Instance;
    void Awake()   //singleton
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public int[] QuestStatus = new int[99];

    private void Start()
    {
        foreach (int S in QuestStatus)
        {
            QuestStatus[S] = 0;
        }    
    }

    public void StartQuest(int QuestNumber)
    {
        QuestStatus[QuestNumber] = 1;
    }
}
