using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CountDisplay : MonoBehaviour
{
    static public int GetCount = 0;
    Text gui;

	// Use this for initialization
	void Start()
	{
        GetCount = 0;
        gui = GetComponent<Text>();
	}

	// Update is called once per frame
	void Update()
	{

		gui.text = " 黃點Collected: " + GetCount +" / 188 " ; 
	}
}