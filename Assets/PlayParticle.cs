using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayParticle : MonoBehaviour
{
    public ParticleSystem ps;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ps.Play();
            Debug.Log("press space");
        }
        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ps.Stop();
        }
        
    }
}
