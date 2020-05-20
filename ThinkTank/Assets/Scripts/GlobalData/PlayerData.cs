using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    #region singleton
    public static PlayerData Instance;
    void Awake()    //this makes sure that there can only be one existance of it aka dont fuck with it
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
    #endregion

    public enum Zones
    {
        //what i can remember of my planned zones, god this gonna be a long haul
        Downtown,
        WildWest,
        Noir,
        Occupation,
        Pirate,
        Future,
        Dinosaur,
        Medieval,
        Sewer,
        ClassicJapan
    }

    public Zones CurrentZone = Zones.Downtown;

    public string PlayerName;

    public int Dollars;
    public int Dennars;
    public int Gold;

}
