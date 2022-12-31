using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerCamera : MonoBehaviour
{
    public GameObject target;
    private Vector3 offset;

    private Vector3 velocity = Vector3.zero;
    public float smoothTime = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, target.transform.position + offset, ref velocity, smoothTime);
    }
}
