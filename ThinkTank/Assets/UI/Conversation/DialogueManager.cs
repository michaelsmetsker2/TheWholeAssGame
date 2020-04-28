using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//NOTE need to set active from this so i dont have to define from each object


public class DialogueManager : MonoBehaviour
{

    #region instance
    public static DialogueManager Instance;
    private void Awake()
    {
        Instance = this;
    }
    #endregion

    //linking the text boxes
    public Text NameText;
    public Text ConvoText;

    private Queue<string> Sentences;

    public bool Manners = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Manners == true)
        {
            DisplayNextSentence();
        }
    }


    public void StartConvo(TalkBlock dialogue)
    {



        //initialize the queue
        Sentences = new Queue<string>();

        NameText.text = dialogue.Name;

        Sentences.Clear();

        foreach (string sentence in dialogue.Sentences)
        {
            //puts the strings in the queue
            Sentences.Enqueue(sentence);
        }
        //displays the first sentence automatically
        DisplayNextSentence();

    }
    public void DisplayNextSentence()
    {
        if (Sentences.Count == 0)
        {
            Manners = false;
            return;
        }

        string sentence = Sentences.Dequeue();
        ConvoText.text = sentence;
    }
}