using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Quest : MonoBehaviour
{
    public string Name;

    public int Status;

    public Goal[] Goals = new Goal[1];

    public bool SpecialSnowflake;

    public void DisplayNext()
    {

    }
}