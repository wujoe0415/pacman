using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frightenedaudio : MonoBehaviour
{
    public AudioSource frightensound;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Navigate.modeon == 3)
        {
            frightensound.Play();

        }
    }
}
