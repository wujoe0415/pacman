using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class collectablemode : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Navigate.time = 10f;

            Destroy(gameObject);

            Navigate.modeon = 3 ;
        }
    }
}
