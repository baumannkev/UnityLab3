using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class PopulateButtons : MonoBehaviour
{
    private ParticleSystem ps;
    public GameObject button;

    public GameObject[] particles;
    private GameObject _activeParticle;

    private void Start()
    {
        int i = 0;
        string[] buttonNames =
        {
            "Fire", "Smoke", "Snow", "StarBurst"
        };
        foreach (string buttonName in buttonNames)
        {
            ParticleButton btn = Instantiate(button, gameObject.transform).GetComponent<ParticleButton>();
            btn.SetName(buttonName);
            btn.order = i;
            btn.Callback = SetParticle;
            
            ++i;
        }
    }

    private void SetParticle(int particleOrder)
    {
        if (_activeParticle != null) Destroy(_activeParticle);
        _activeParticle = Instantiate(particles[particleOrder], Vector3.forward, Quaternion.identity);
        ps = _activeParticle.GetComponent<ParticleSystem>();
        ps.Play();
        
        Debug.Log("Setting part");
    }
    /*public GameObject buttonPrefab;
    public Transform content;
    public ParticleSystem psFire;
    public ParticleSystem psStar;
    public List<GameObject> particlesToSpawn = new List<GameObject>();

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
        starburstButton.callbackParticle = StarButtonClicked;

    }

    public void ButtonClicked(string buttonText)
    {
        psFire.Play();
        Debug.Log("Clicked: " + buttonText);
    }

    public void StarButtonClicked(string buttonText, ParticleSystem ps)
    {
        Debug.Log("Clicked: " + buttonText);
        ps.Stop();
        ps.Play();
    }*/

}
