using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceManager : MonoBehaviour
{

    public int Chosen = 0;

    public GameObject Box1;
    public Text CText1;

    public GameObject Box2;
    public Text CText2;
    
    public GameObject Box3;
    public Text CText3;
    
    public GameObject Box4;
    public Text CText4;


    public void StartChoice(int Options, ChoiceBlock Input)
    {
        Chosen = 0;

        switch (Options)
        {
            case 1:
                {
                    Box1.SetActive(true);
                    Box2.SetActive(false);
                    Box3.SetActive(false);
                    Box4.SetActive(false);
                    break;
                }
            case 2:
                {
                    Box1.SetActive(true);
                    Box2.SetActive(true);
                    Box3.SetActive(false);
                    Box4.SetActive(false);
                    break;
                }
            case 3:
                {
                    Box1.SetActive(true);
                    Box2.SetActive(true);
                    Box3.SetActive(true);
                    Box4.SetActive(false);
                    break;
                }
            case 4:
                {
                    Box1.SetActive(true);
                    Box2.SetActive(true);
                    Box3.SetActive(true);
                    Box4.SetActive(true);
                    break;
                }
            default:
                {
                    Debug.LogError("something fucked up, int options shouldnt be" + Options);
                    break;
                }
        }

        CText1.text = Input.Option1;
        CText2.text = Input.Option2;
        CText3.text = Input.Option3;
        CText4.text = Input.Option4;
    }

    public void Select1()
    {
        Chosen = 1;
    }

    public void Select2()
    {
        Chosen = 2;
    }
    public void Select3()
    {
        Chosen = 3;
    }
    public void Select4()
    {
        Chosen = 4;
    }
}