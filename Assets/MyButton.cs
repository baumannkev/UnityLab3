using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class MyButton : MonoBehaviour, IPointerClickHandler
{
    public TMP_Text text; // Access to text script

    public System.Action<string> callback; //create a callback function

    // Start is called before the first frame update

    public void OnPointerClick(PointerEventData data)
    {
        callback?.Invoke(text.text); //calls callback function andpasses back string in the text
    }

    public void SetText(string s)
    {
        text.SetText(s);
    }
}
