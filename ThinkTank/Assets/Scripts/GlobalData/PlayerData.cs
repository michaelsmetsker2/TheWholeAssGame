using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public static PlayerData Instance;

    private void Awake()
    {
        Instance = this;
    }

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

    public int Dollars;
    public int Dennars;
    public int Gold;

}
