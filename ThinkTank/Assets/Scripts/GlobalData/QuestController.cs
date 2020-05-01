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

    //51 even though theres only 50 slots because an extra slot to put shit down before sorting
    public Quest[] SlotID = new Quest[51];

    public void StartQuest(Quest Given)
    {
        if (SlotID.Contains(Given))
        {
            Debug.LogWarning("duplicate quest " + Given);
        }
        else
        {
            Debug.LogError("Fix This");
            SlotID[51] = Given;
        }

        IEnumerable<Quest> query = SlotID.OrderBy(Quest => Quest.Completed);

        Debug.Log("Display Quest Popup here");
    }
}