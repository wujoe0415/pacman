﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class usualmusic : MonoBehaviour
{
    public AudioSource game;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Navigate.modeon == 0)
        {
            game.Play();
        }
    }
}
