using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectedInfo : MonoBehaviour
{
    public Text DescriptionBox;

    public void DisplayInfo(string Info)
    {
        DescriptionBox.text = Info;
    }
}
