using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tryagain : MonoBehaviour
{
    void Update()
    {
        if (Navigate.gg == 10)
        {
            Cursor.visible = true;
            SceneManager.LoadScene(0);
        }

    }
}