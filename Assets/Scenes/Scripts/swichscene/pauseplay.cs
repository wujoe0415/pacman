﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseplay : MonoBehaviour
{
    private bool click = false;
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R) & Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
        if (Input.GetKey(KeyCode.Space) & Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
    }
}
