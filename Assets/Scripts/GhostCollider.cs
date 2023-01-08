using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostCollider : MonoBehaviour
{
    public Transform player;
    public Transform wh1;
    public Transform wh2;
    public Transform wh3;
    public Transform wh4;

    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreCollision(player.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(wh1.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(wh2.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(wh3.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(wh4.GetComponent<Collider>(), GetComponent<Collider>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
