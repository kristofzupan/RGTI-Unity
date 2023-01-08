using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player")
        {
            return;
        }

        Globals.checkpoint1 = true;
    }
}
