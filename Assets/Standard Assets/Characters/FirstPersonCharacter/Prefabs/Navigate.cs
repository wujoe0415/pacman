using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class Navigate : MonoBehaviour {

	NavMeshAgent nav;

	public Transform target;

	// Use this for initialization
	void Start () {
	
		nav = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		nav.destination = target.position;
	}
}
