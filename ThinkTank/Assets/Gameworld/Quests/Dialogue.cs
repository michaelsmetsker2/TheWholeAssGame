using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : BaseConvo
{
    public string Name;

    [TextArea(3, 10)]
    public string[] Sentences;

    public int NextUp;
}