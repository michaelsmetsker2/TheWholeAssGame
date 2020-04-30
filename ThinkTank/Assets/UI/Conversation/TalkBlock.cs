using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TalkBlock
{
    //speakers name
    public string Speaker;
    [TextArea(3, 10)]
    public string[] Sentences;

    public bool HasQuestion;

    //please only up to four
    public string[] Options = new string[4];

}