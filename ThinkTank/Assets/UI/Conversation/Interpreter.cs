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

    public GameObject ChoiceUI;
    public GameObject TalkBox;

    //the four options's gameobjects
    public GameObject[] OpBox = new GameObject[4];
    //the text boxes on the four options
    public Text[] Otex = new Text[4];

    //linking the text boxes
    public Text NameText;
    public Text ConvoText;

    [HideInInspector]
    public int Chosen = 0;

    private TalkBlock CurrentBlock;

    private Queue<string> QText;

    public void StartConvo(TalkBlock Block)
    {

        CurrentBlock = Block;

        QText = new Queue<string>();
        QText.Clear();

        //initialize queue
        foreach (Sentences sentence in CurrentBlock.Sentences)
        {

            QText.Enqueue(sentence.Speaker);

            QText.Enqueue(sentence.Text);
        }

        TalkBox.SetActive(true);

        //first sentence starts automatically
        DisplayNextSentence();
    }

    private void DisplayNextSentence()
    {
        //when theres no more sentences left
        if (QText.Count == 0)
        {
            TalkBox.SetActive(false);
            MakeChoice();
            return;
        }

        string CurrentSpeaker = QText.Dequeue();

        if (CurrentSpeaker == "Player")
        {
            NameText.text = PlayerData.Instance.PlayerName;
        }
        else
        {
            NameText.text = CurrentSpeaker;
        }

        string CurrentLine = QText.Dequeue();
        ConvoText.text = CurrentLine;

        StartCoroutine(GetE());
    }

    private IEnumerator GetE()
    {
        yield return new WaitForEndOfFrame();
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.E));
        DisplayNextSentence();
    }


    public void MakeChoice()
    {
        if (CurrentBlock.HasQuestion)
        {
            ChoiceUI.SetActive(true);

            Chosen = 0;
            //only set the needed choice boxes to active
            for (int O = 0; O < 4; O++)
            {
                if (CurrentBlock.Options.Length >= O + 1)
                {
                    OpBox[O].SetActive(true);
                    Otex[O].text = CurrentBlock.Options[O];
                }
                else
                {
                    OpBox[O].SetActive(false);
                }
            }
        }
        else
        {
            Time.timeScale = 1f;
        }
    }


    public void Select1()
    {
        Chosen = 1;
        ChoiceUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Select2()
    {
        Chosen = 2;
        ChoiceUI.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Select3()
    {
        Chosen = 3;
        ChoiceUI.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Select4()
    {
        Chosen = 4;
        ChoiceUI.SetActive(false);
        Time.timeScale = 1f;
    }
}