using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenu : MonoBehaviour
{
    //is menu open?
    public bool IsOpen = false;

    public GameObject MenuUi;

    public static GameMenu Instance;

    private void Awake()
    {
        Instance = this;
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

    public void Open()
    {
        MenuUi.SetActive(true);
        Time.timeScale = 0f;
        IsOpen = true;
    }

    public void Close()
    {
        MenuUi.SetActive(false);
        Time.timeScale = 1f;
        IsOpen = false;
    }
}