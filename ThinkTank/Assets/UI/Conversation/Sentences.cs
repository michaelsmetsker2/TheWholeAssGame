using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sentences
{
    public string Speaker;

    [TextArea(3, 10)]
    public string Text;

}