using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiSelected : MonoBehaviour
{
    #region instance
    public static UiSelected Instance;
    private void Awake()
    {
        Instance = this;
    }
    #endregion

    public ItemInteract ItemInteract;

    public GameObject QuestMenu;

    public Text Description;
    public Image LargeIcon;

    public void Clear()
    {
        Description.text = null;
        ItemInteract.gameObject.SetActive(false);

        QuestMenu.SetActive(true);

        Debug.Log("Hey put the map here instead of null, loser");
        LargeIcon.sprite = null;
    }

    public void SelectItem(Item Selected)
    {
        Clear();
        Description.text = Selected.Description;
        LargeIcon.sprite = Selected.IconL;

        QuestMenu.SetActive(false);

        ItemInteract.gameObject.SetActive(true);
        ItemInteract.StartInteract(Selected);

    }

    public void SelectQuest(Quest Selected)
    {
        Clear();

        //need to place map marker

        //need to place down descriptions

        foreach (Goal G in Selected.Goals)
        {
            Description.text += "\n" + G.Description + " " + G.CurrentAmount +"/" + G.RequiredAmount;
        }
    }
}
