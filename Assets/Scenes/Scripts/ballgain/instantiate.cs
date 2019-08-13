using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiate : MonoBehaviour {
    public GameObject ball ;
    public Vector3 pos ;
    public float step ;
    public float len ;



    // Use this for initialization
    void Start () {
        Vector3 pos = transform.position;


        for (int i = 0; i < len; i++) 
        {
            Instantiate(ball, pos, Quaternion.identity) ;
            pos += transform.forward * step ;
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
    
}
