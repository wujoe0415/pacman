using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class A3 : MonoBehaviour
{
    NavMeshAgent nav;
	public Transform target1;
	public Transform target2;
    public Transform home3;
	public Transform spawn3;
    float new_x;
	float new_y;
	float distance;
	Vector3 front;
	Vector3 targetPosition;
	
    // Start is called before the first frame update
    void Start()
    {
		nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos1 = target1.transform.position;
        Vector3 pos2 = target2.transform.position + target2.transform.forward * 16;
		distance = Vector3.Distance(pos1, pos2);
		front = (pos2 - pos1).normalized;
		
		RaycastHit[] hits = Physics.RaycastAll(pos1, front , 2 * distance);
        int length = hits.Length;

        

        if(Time.timeScale == 1)
        {
            if (length > 0)
            {
                
                this.targetPosition = hits[length - 1].point - front;
            }
            else
            {
               
                this.targetPosition = target2.transform.position;
            }
        }

        if(!nav.SetDestination(this.targetPosition))
        {
            Gizmos.color = Color.red;
        }
        else
        {
            Gizmos.color = Color.green;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(this.targetPosition, 3f);
    }
	
}
