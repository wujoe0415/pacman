using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class A : MonoBehaviour
{
    NavMeshAgent nav;
    public Transform home1;
    public Transform player;
    public Vector3 spawn1;


    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1)
        {
            if (Navigate.modeon == 0)
            {
                nav.destination = player.transform.position;
            }

            if (Navigate.modeon == 1)
            {
                nav.destination = home1.transform.position;

            }
        }
       

    }
}
