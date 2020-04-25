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

    public Text Description;
    public Image LargeIcon;

    public void Clear()
    {
        Description.text = null;
        //change largeIcon to map
    }

    public void SelectItem(Item Selected)
    {
        Clear();
        Description.text = Selected.Description;
        LargeIcon.sprite = Selected.IconL;

    }

    public void SelectQuest()
    {
        Clear();

    }
}
