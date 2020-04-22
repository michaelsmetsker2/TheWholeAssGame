using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataState : MonoBehaviour
{

    public PlayerController PlayerController;

    public int Money = 52;


    //Save data to global control   
    public void Save()
    {
        PlayerController.Money = Money;
    }
}
