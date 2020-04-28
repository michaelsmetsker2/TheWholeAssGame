using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interpreter : MonoBehaviour
{
    #region instance
    public static Interpreter Instance;

    private void Awake()
    {
        Instance = this;
    }
    #endregion

    public GameObject TalkBox;

    public GameObject[] OpBox = new GameObject[4];

    public Text[] Otex = new Text[4];

    //linking the text boxes
    public Text NameText;
    public Text ConvoText;

    public void StartConvo(TalkBlock Block)
    {
        TalkBox.SetActive(true);

        NameText.text = Block.Name;

        foreach (string Sentence in Block.Sentences)
        {
            //displays the first sentence automatically
            StartCoroutine(DisplayNextSentence(Sentence));
        }
        
        if (Block.HasQuestion)
        {
            for (int O = 0; O < 4; O++)
            {
                if (Block.Options != null)
                {
                    OpBox[O].SetActive(true);
                    Otex[O].text = Block.Options[O];
                    //add get press here
                }
            }    
        }
    }

    IEnumerator DisplayNextSentence(string Sentence)
    {
        ConvoText.text = Sentence;
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.E));
    }

    public void Select1()
    {
        Chosen = 1;
    }

    public void Select2()
    {
        Chosen = 2;
    }
    public void Select3()
    {
        Chosen = 3;
    }
    public void Select4()
    {
        Chosen = 4;
    }
}