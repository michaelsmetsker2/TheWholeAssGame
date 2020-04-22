using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string SceneName; //the scene you'll be loading

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<DataState>().Save(); //saves playerdata to global controller

            SceneManager.LoadScene(SceneName); // loads scene When player enter the trigger collider
        }
    }
}