using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;

    [Range(0, 1000)]
    public float torque = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float ha = Input.GetAxis("Horizontal");
        float va = Input.GetAxis("Vertical");

        Vector3 hTorque = Vector3.forward * -ha * this.torque;
        Vector3 vTorque = Vector3.right * va * this.torque;

        rb.AddTorque(hTorque, ForceMode.Acceleration);
        rb.AddTorque(vTorque, ForceMode.Acceleration);
    }
}
