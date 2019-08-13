using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frightenedmusic : MonoBehaviour
{
    public AudioSource frightened ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Navigate.modeon == 1)
        {
            frightened.Play();
        }
    }


}
