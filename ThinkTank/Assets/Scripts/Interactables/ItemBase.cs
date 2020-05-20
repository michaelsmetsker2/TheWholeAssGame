using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBase : MonoBehaviour
{

    public string Received;

    public void Initiate()
    {
        GameMenu.Instance.MenuUi.SetActive(true);
        StartCoroutine(GetItem());
    }

    public virtual void Action()
    {
        Debug.LogWarning("this should be overwritten");
    }

    public IEnumerator GetItem()
    {
        yield return new WaitUntil(() => UiSelected.Instance.SelectedItem != null);
        Received = UiSelected.Instance.SelectedItem;
        GameMenu.Instance.MenuUi.SetActive(false);
        Action();
    }

}
