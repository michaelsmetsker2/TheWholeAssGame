using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactables : MonoBehaviour
{
    //The interact menu's script and object
    public InteractionManager InteractMenu;
    public GameObject MenuObject;

    public GameObject FButton;

    //the object that is being interacted with
    private TalkTo TalkBehavior;
    private OnUse UseBehavior;
    private OnItem ItemReactions;
    //ect

    //dialogue ui link
    public GameObject TalkBox;
    //DialogueManager
    public DialogueManager TManager;


    private void Start()
    {
        //saves computing power
        enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Interactable")
        {
            TalkBehavior = other.gameObject.GetComponent<TalkTo>();
            //and the others <3

            FButton.SetActive(true);
            enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Interactable")
        {
            FButton.SetActive(false);
            enabled = false;
        }
    }

    void Update()
    {
        //opens menu
        if (Input.GetKeyDown(KeyCode.F)&& Time.timeScale == 1f)
        {
            Time.timeScale = 0f;
            MenuObject.SetActive(true);
            StartCoroutine(InteractMenu.GetPress());
        }
    }

    //determines press
    public void DeterminePress(int InteractType)
    {
        switch (InteractType)
        {
            case 1: //talk
                {
                    MenuObject.SetActive(false);
                    TalkBehavior.Initiate();
                    break;
                }
            case 2: //item
                {
                    MenuObject.SetActive(false);
                    break;
                }
            case 3: //use
                {
                    MenuObject.SetActive(false);
                    break;
                }
            case 4: //exit
                {
                    MenuObject.SetActive(false);
                    Time.timeScale = 1f;
                    break;
                }
        }
    }
}