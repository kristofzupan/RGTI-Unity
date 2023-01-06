using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint3 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Globals.checkpoint3 = true;
    }
}
