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

    public Text Description;
    public Image LargeIcon;

    public void Clear()
    {
        Description.text = null;
        ItemInteract.gameObject.SetActive(false);

        Debug.Log("Hey put the map here instead of null, loser");
        LargeIcon.sprite = null;
    }

    public void SelectItem(Item Selected)
    {
        Clear();
        Description.text = Selected.Description;
        LargeIcon.sprite = Selected.IconL;
        ItemInteract.gameObject.SetActive(true);
        ItemInteract.StartInteract(Selected);

    }

    public void SelectQuest()
    {
        Clear();

    }
}
