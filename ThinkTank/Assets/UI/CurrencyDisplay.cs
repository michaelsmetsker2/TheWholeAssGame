using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyDisplay : MonoBehaviour
{
    public Text MoneyUI;

    public static CurrencyDisplay Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UpdateCount();
    }


    //this should be call ed when you enter a new zone or your money changes

    //this is just to update the ui not update the amount of money you have
    public void UpdateCount()
    {
        switch(PlayerData.Instance.CurrentZone)
        {
            case PlayerData.Zones.Downtown:
                {
                    MoneyUI.text = PlayerData.Instance.Dollars.ToString();
                    break;
                }
            default:
                {
                    Debug.LogError("currency isnt hooked up for this zone");
                    break;
                }
        }
    }
}
