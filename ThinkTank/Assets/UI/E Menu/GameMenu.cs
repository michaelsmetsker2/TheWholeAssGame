using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenu : MonoBehaviour
{
    //link components
    public GameObject MenuUI;

    //is menu open?
    public bool IsOpen = false;

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
}