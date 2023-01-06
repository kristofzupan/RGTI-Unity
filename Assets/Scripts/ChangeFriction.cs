using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeFriction : MonoBehaviour
{
    public Component comp;
    public Rigidbody rb;
    private float dragOnStart;

    void Start()
    {
        rb = comp.GetComponent<Rigidbody>();
        dragOnStart = rb.drag;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            rb.drag = 1;
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            rb.drag = dragOnStart;
        }

    }
}
