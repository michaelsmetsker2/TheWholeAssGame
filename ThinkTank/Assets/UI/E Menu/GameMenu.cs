using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenu : MonoBehaviour
{

    //link components
    public GameObject MenuUI;
    public GameObject[] InvPages;

    //selected page to change to
    private int ISelected = 0;

    //currently shown page
    private GameObject InvActivePage;

    //is menu open?
    public bool IsOpen = false;

    private void Start()
    {
        InvActivePage = InvPages[ISelected];
        ChangePages();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (IsOpen)
            {
                Close();
            }
            else
            {
                if (Time.timeScale == 1f)
                {
                    Open();
                }
            }
        }
    }

    void Open()
    {
        MenuUI.SetActive(true);
        Time.timeScale = 0f;
        IsOpen = true;
    }

    void Close()
    {
        MenuUI.SetActive(false);
        Time.timeScale = 1f;
        IsOpen = false;
    }

    void ChangePages()
    {
        if (ISelected > InvPages.Length - 1)
            ISelected = InvPages.Length - 1;
        else
            if (ISelected < 0)
            ISelected = 0;

        //reset the shown page
        InvActivePage.SetActive(false);
        InvActivePage = InvPages[ISelected];
        InvActivePage.SetActive(true);
    }

    public void InvPrevious()
    {
        ISelected--;
        ChangePages();
    }

    public void InvNext()
    {
        ISelected++;
        ChangePages();
    }
}