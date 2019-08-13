using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    void Update()
    {
        if (CountDisplay.GetCount == 188)
        {
            Cursor.visible = true;
            SceneManager.LoadScene(2);
        }

    }
}
    
