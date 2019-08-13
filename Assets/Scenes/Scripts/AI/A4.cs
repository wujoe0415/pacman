using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class A4 : MonoBehaviour
{
    NavMeshAgent nav;
	float distance = 10;
	public Transform player3;
	public Transform left;
    public Transform right;
    public Transform home4;
	public Transform spawn4;
	
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
		nav = this.GetComponent<NavMeshAgent>();
        if(Time.timeScale == 1)
        {
            if (Navigate.modeon == 0)
            {
                if (Vector3.Distance(this.transform.position, player3.transform.position) < distance)
                {
                    if (Vector3.Distance(this.transform.position, left.transform.position) < Vector3.Distance(this.transform.position, right.transform.position))
                    {
                        nav.destination = left.transform.position;
                    }
                    else
                    {
                        nav.destination = right.transform.position;
                    }
                }
                else
                {
                    nav.destination = player3.transform.position + player3.transform.forward;
                }
            }

            if (Navigate.modeon == 1)
            {
                nav.destination = home4.position;
            }
            
        }
		
    }
	void OnCollisionEnter(Collision hit)
    {
		if(hit.gameObject.tag == "Player")
		{
			if (Navigate.modeon == 1)
            {
                this.transform.position = spawn4.transform.position;			
            }			
		}
	}
}    
