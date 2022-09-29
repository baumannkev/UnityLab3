using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class PopulateButtons : MonoBehaviour
{
    public GameObject buttonPrefab;
    
    public Transform content;

    // Start is called before the first frame update
    void Start()
    {
        MyButton fireButton = Instantiate(buttonPrefab, content).GetComponent<MyButton>();
        fireButton.SetText("Fire");
        fireButton.callback = ButtonClicked;

        MyButton smokeButton = Instantiate(buttonPrefab, content).GetComponent<MyButton>();
        smokeButton.SetText("Smoke");
        smokeButton.callback = ButtonClicked;

        MyButton snowButton = Instantiate(buttonPrefab, content).GetComponent<MyButton>();
        snowButton.SetText("Snow");
        snowButton.callback = ButtonClicked;

        MyButton starburstButton = Instantiate(buttonPrefab, content).GetComponent<MyButton>();
        starburstButton.SetText("Starburst");
        starburstButton.callback = ButtonClicked;
    }

    public void ButtonClicked(string buttonText)
    {
        Debug.Log("Clicked: " + buttonText);
    }
}
