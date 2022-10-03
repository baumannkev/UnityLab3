using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class ParticleButton : MonoBehaviour, IPointerClickHandler
{
    public TMP_Text txt;
    public Action<int> Callback;
    public int order;
    public void OnPointerClick(PointerEventData data)
    {
        Debug.Log("Click");
        Callback?.Invoke(order);
    }

    public void SetName(string text)
    {
        gameObject.name = text;
        txt.SetText(text);
    }

}