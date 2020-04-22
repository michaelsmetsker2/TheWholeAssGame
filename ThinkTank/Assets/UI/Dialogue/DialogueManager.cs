using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
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
        Manners = true;

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