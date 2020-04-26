using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactables : MonoBehaviour
{
    //The interact menu
    public InteractionManager InteractMenu;

    public GameObject FButton;

    public GameObject InteractObject;
    private InteractBehaviors InteractBehaviors;

    private void Start()
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
            enabled = true;
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

    void Update()
    {
        //opens menu
        if (Input.GetKeyDown(KeyCode.F)&& Time.timeScale == 1f)
        {
            Time.timeScale = 0f;
            InteractMenu.gameObject.SetActive(true);
            StartCoroutine (GetPress());
        }
    }

    public IEnumerator GetPress()
    {
        yield return new WaitUntil(() => InteractMenu.PressId != 0);

        Debug.LogWarning("this could probably be more efficient");

        if (InteractMenu.PressId == 4)
        {
            InteractMenu.gameObject.SetActive(false);
            Time.timeScale = 1f;
        }
        else
        {
            InteractMenu.gameObject.SetActive(false);
            InteractObject.gameObject.GetComponent<InteractBehaviors>().Actions(InteractMenu.PressId);
        }
        InteractMenu.ResetPress();
    }
}