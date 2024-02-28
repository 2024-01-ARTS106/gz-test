using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballroll : MonoBehaviour
{
    Rigidbody rb;

    float HorizontalMovement;
    public float ForwardMovement { get; private set; }

    float forwardMovement;
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalMovement = Input.GetAxis("Horizontal");
        ForwardMovement = Input.GetAxis("Vertical");

        Vector3 movementforce = new Vector3(HorizontalMovement, 0f, forwardMovement);
        rb.AddForce(movementforce);
    }
}
