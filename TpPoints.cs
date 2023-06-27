using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TpPoints : MonoBehaviour
{
    public Transform player;
    public Transform points;

    private void OnTriggerStay(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
                player.position = points.position;
        }
    }
}
