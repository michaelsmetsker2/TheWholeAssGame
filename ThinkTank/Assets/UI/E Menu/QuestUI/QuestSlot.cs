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
        if (SlotNumber > QuestController.Instance.SlotID.Count - 1)
        {
            ButtonBox.text = null;
            Empty = true;
        }
        else
        {
            if (QuestController.Instance.SlotID[SlotNumber].Completed)
            {
                ButtonBox.color = Color.green;
            }
            else
            {
                ButtonBox.color = Color.black;
            }

            ButtonBox.text = QuestController.Instance.SlotID[SlotNumber].Name;
            Empty = false;
        }
    }

    public void Select()
    {
        //add double click to return to nothing selected0

        if (Empty == false)
        {
            if (UiSelected.Instance.IsSelecting)
            {
                Debug.LogWarning("fix this shit");
                UiSelected.Instance.Clear();
            }
            else
            {
                UiSelected.Instance.SelectQuest(QuestController.Instance.SlotID[SlotNumber]);
            }
        }
    }
}
