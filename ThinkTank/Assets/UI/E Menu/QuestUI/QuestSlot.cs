using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestSlot : MonoBehaviour
{

    //order of slot on the page
    public int SlotNumber;

    public Text ButtonBox;

    //if the slot is holding an item
    private bool Empty = true;

    private void OnEnable()
    {
        if (QuestController.Instance.SlotID[SlotNumber] != null)
        {
            Empty = false;
            ButtonBox.text = QuestController.Instance.SlotID[SlotNumber].Name;
        }
        else
        {
            Empty = true;
            ButtonBox.text = null;
        }
    }

    public void Select()
    {
        if (Empty == false)
        {
            UiSelected.Instance.SelectQuest(QuestController.Instance.SlotID[SlotNumber]);
        }
    }
}
