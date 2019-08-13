using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class A2 : MonoBehaviour
{
    NavMeshAgent nav;
    public Transform player2;
    public Transform home2;
	public Transform spawn2;
	
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale == 1)
        {
            if (Navigate.modeon == 0)
            {
                nav = this.GetComponent<NavMeshAgent>();
                nav.destination = player2.transform.position + player2.transform.forward*4;
            }

            if (Navigate.modeon == 1)
            {
                nav.destination = home2.transform.position;
			
            }
        }
    }
	void OnCollisionEnter(Collision hit)
    {
		if(hit.gameObject.tag == "Player")
		{
			if (Navigate.modeon == 1)
            {
                this.transform.position = spawn2.transform.position;			
            }			
		}
	}
}
