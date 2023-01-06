using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint2 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Globals.checkpoint2 = true;
    }
}
