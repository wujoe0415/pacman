using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class CollectableBall : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log(name);
            CountDisplay.GetCount++;
            Destroy(gameObject);
            Navigate.modeon = 2;
        }
    }
}