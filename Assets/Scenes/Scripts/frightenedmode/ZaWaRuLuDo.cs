using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZaWaRuLuDo : MonoBehaviour
{

    Text gui;

    // Start is called before the first frame update
    void Start()
    {
        gui = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Navigate.modeon == 1)
        {
            gui.text = " 驚嚇模式倒數: " + Navigate.time;
        }
        else if (Navigate.modeon == 0)
        {

            gui.text = " ";
        }
          
    }
}