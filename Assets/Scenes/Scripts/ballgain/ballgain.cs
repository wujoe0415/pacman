using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballgain : MonoBehaviour
{
    public AudioSource gainsound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Navigate.modeon == 2)
        {
            gainsound.Play();

        }
    }
}
