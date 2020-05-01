using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryMenu : MonoBehaviour
{
    public GameObject[] Pages;

    private int CurrentPage;

    private void Awake()
    {
        Pages[0].SetActive(true);
        CurrentPage = 0;
    }

    void ChangePages()
    {
        if (CurrentPage > Pages.Length - 1)
        {
            CurrentPage = Pages.Length - 1;
        }

        if (CurrentPage < 0)
        {
            CurrentPage = 0;
        }

        Pages[CurrentPage].SetActive(true);
    }

    public void InvPrevious()
    {
        Pages[CurrentPage].SetActive(false);
        CurrentPage--;
        ChangePages();
    }

    public void InvNext()
    {
        Pages[CurrentPage].SetActive(false);
        CurrentPage++;
        ChangePages();
    }
}
