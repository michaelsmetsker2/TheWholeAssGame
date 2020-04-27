using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attached to player
public class Interactables : MonoBehaviour
{
    //The menu that pops up after pressing f near an object/npc
    public InteractionManager InteractMenu;
    //the f icon that shows up when near an interactable object
    public GameObject FButton;

    //the object that's  being interacted with (is set when in range) (i should probably change that to save gpus stuff)
    public GameObject InteractObject;

    private void Start() //initiation
    {
        //so it only tests for an f press while in range of an interactable
        enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Interactable"))
        {
            InteractObject = other.gameObject;
            FButton.SetActive(true);
            enabled = true; //so update will run and test for an f press
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Interactable"))
        {
            FButton.SetActive(false);
            enabled = false;
        }
    }

    void Update() //will run every frame while enabled = true
    {
        //opens menu
        if (Input.GetKeyDown(KeyCode.F)&& Time.timeScale == 1f)
        {
            Time.timeScale = 0f;
            InteractMenu.gameObject.SetActive(true);
            StartCoroutine (GetPress());
        }
    }

    //waits until a menu option is chosen and then sends button value to the objects behavioral script
    public IEnumerator GetPress()
    {
        yield return new WaitUntil(() => InteractMenu.PressId != 0);

        switch (InteractMenu.PressId)
        {
            case 1: //talk
                {
                    InteractMenu.PressId = 0;
                    InteractMenu.gameObject.SetActive(false);
                    InteractObject.GetComponent<TalkBase>().Initiate();
                    break;
                }
            case 2: //item
                {
                    InteractMenu.PressId = 0;
                    InteractMenu.gameObject.SetActive(false);
                    InteractObject.GetComponent<ItemBase>().Initiate();
                    break;
                }
            case 3: //use
                {
                    InteractMenu.PressId = 0;
                    InteractMenu.gameObject.SetActive(false);
                    InteractObject.GetComponent<UseBase>().Initiate();
                    break;
                }
            case 4: //exit
                {
                    InteractMenu.PressId = 0;
                    InteractMenu.gameObject.SetActive(false);
                    Time.timeScale = 1f;
                    break;
                }
        }
    }
}