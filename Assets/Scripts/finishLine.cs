using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishLine : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(Globals.checkpoint1 && Globals.checkpoint2 && Globals.checkpoint3)
        {
            Debug.Log("finish");
        }
    }

}
