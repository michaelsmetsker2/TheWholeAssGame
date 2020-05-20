using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TalkBlock
{
    public Sentences[] Sentences;

    public bool HasQuestion;

    //please only up to four
    public string[] Options = new string[4];
}