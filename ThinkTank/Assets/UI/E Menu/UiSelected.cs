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

    public bool IsSelecting;

    //for the item interaction
    public string SelectedItem;

    private void OnEnable()
    {
        Clear();
    }

    public void Clear()
    {
        SelectedItem = null;

        Description.text = null;
        ItemInteract.gameObject.SetActive(false);

        QuestMenu.SetActive(true);

        //put map here

        LargeIcon.sprite = null;

        IsSelecting = false;
    }

    public void SelectItem(Item Selected)
    {
        Clear();

        SelectedItem = Selected.name;

        Description.text = Selected.Description;
        LargeIcon.sprite = Selected.IconL;

        QuestMenu.SetActive(false);

        ItemInteract.gameObject.SetActive(true);
        ItemInteract.StartInteract(Selected);

        IsSelecting = true;
    }

    public void SelectQuest(Quest Selected)
    {
        Clear();

        //need to place map marker

        //need to place down descriptions

        foreach (Goal G in Selected.Goals)
        {
            if (G.Completed)
            {
                Description.text += G.Description + " Complete\n";
            }
            else
            {
                Description.text += G.Description + " " + G.CurrentAmount +"/" + G.RequiredAmount + "\n";
            }
        }

        IsSelecting = true;
    }
}
