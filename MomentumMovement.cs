using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomentumMovement : MonoBehaviour
{
    public Transform cam;

    public float speed;
    private Rigidbody rb;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
     
        movement = cam.TransformDirection(movement);
        rb.AddForce(movement * speed);
    }
    private void FixedUpdate()
    {
        cam.eulerAngles = new Vector3(0, cam.eulerAngles.y, cam.eulerAngles.z);
        if (rb.velocity.magnitude > 30)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, 30);
        }

    }
}