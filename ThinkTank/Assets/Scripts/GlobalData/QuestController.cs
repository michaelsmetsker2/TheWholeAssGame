using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class QuestController : MonoBehaviour
{
    #region Instance
    public static QuestController Instance;
    void Awake()
    {
        Instance = this;
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
            SlotID.Add(Given);
        }

        SlotID.OrderBy(Q => Q.Completed);




        Debug.Log("Display Quest Popup here");
    }
}