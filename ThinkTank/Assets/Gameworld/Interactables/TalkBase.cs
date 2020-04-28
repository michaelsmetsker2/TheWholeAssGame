using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkBase : MonoBehaviour
{
    public virtual void Initiate()
    {
        Debug.LogError("this should be overriten");
    }
}

/*
{
    //wanna go anouther round on initiate?
    private bool Another;

    //NPC data

    private int Answer;

    //Talk state
    private int TalkState = 0;

    //first conversation
    public TalkBlock TBlock0;

    //accept quest or not
    public ChoiceBlock Choices1;

    //accepted quest
    public TalkBlock TBlock2;

    //not acceptde quest
    public TalkBlock TBlock3;

    public SlotController SlotController;

    public Item Given;
    public override void Initiate()
    {
        switch (TalkState)
        {
            case 0:
                {
                    DialogueManager.Instance.StartConvo(TBlock0);
                    TalkState = 1;
                    Another = true;
                    StartCoroutine(NextUp());
                    break;
                }
            case 1:
                {
                    Boolhavior.ChoiceManager.StartChoice(2,Choices1);
                    StartCoroutine(GetAnswer());
                    break;
                }
            case 2:
                {
                    Boolhavior.TManager.StartConvo(TBlock2);
                    Another = false;
                    StartCoroutine(NextUp());
                    break;
                }
            case 3:
                {
                    Boolhavior.TManager.StartConvo(TBlock3);
                    TalkState = 1;
                    Another = true;
                    StartCoroutine(NextUp());
                    break;
                }

        }
        
    }

    IEnumerator NextUp() //have this in all / other script??
    {
        yield return new WaitUntil(() => Boolhavior.TManager.Manners == false);
        Boolhavior.TalkBox.SetActive(false);

        if (Another == true)
        {
            Initiate();
        }
        else
        {
            Exit();
        }
    }

    IEnumerator GetAnswer()
    {
        yield return new WaitUntil(() => Boolhavior.ChoiceManager.Chosen != 0);
        Answer = Boolhavior.ChoiceManager.Chosen;
        Boolhavior.ChoiceUI.SetActive(false);

        if (Answer == 1) //option one
        {
            //give item
            SlotController.NewItem(Given);
            TalkState = 2;
            Exit();
        }
        else
        {
            TalkState = 3;
            Exit();
        }    
    }

    private void Exit()
    {
        Time.timeScale = 1f;
    }
}
*/