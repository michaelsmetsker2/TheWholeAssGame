using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class QuestController : MonoBehaviour
{
    #region singleton
    public static QuestController Instance;
    void Awake()    //this makes sure that there can only be one existance of it aka dont fuck with it
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
    #endregion

    public List<Quest> SlotID = new List<Quest>(0);

    public void StartQuest(Quest Given)
    {
        if (SlotID.Contains(Given))
        {
            Debug.LogWarning("duplicate quest " + Given);
        }
        else
        {
            Given.Init();
            SlotID.Add(Given);
        }

        SlotID.OrderBy(Q => Q.Completed);

        //Display Quest Popup here
    }
}