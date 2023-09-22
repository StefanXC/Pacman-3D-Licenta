using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]


public class MotorPacman : MonoBehaviour {


    private Vector3 velocity = Vector3.zero;
    private Vector3 rotire   = Vector3.zero;


    private Rigidbody rb;


	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
    public void Muta (Vector3 _velocity)
    {
        velocity = _velocity;
    }

    public void Rotatie(Vector3 _rotire)
    {
        rotire = _rotire;
    }

    void FixedUpdate()
    {
        PerformMovement();
        PerformRotire();
    }


    void PerformMovement()
    {
        if(velocity != Vector3.zero)
        {
            rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
        }
    }

    void PerformRotire()
    {
        rb.MoveRotation(rb.rotation * Quaternion.Euler (rotire));


    }


}
