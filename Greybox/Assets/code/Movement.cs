using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public bool onGround;
    private Rigidbody rb;

    public float moveSpeed = 10.0F;

    public float airMultiplier = 0.5F;

	void Start ()
    {
        onGround = true;
        rb = GetComponent<Rigidbody>();
		
	}
	
	
	void FixedUpdate ()
    {
        Vector3 velocity = rb.velocity;
        if(onGround)
        {
            if (Input.GetButtonDown("Jump"))
            {
                velocity.y = 7F;
                onGround = false;
            } 
        }

        float currentMoveSpeed = moveSpeed;

        if(!onGround)
        {
            currentMoveSpeed *= airMultiplier;
        }

        velocity.x = Input.GetAxis("Horizontal") * currentMoveSpeed;

        rb.velocity = velocity;
	}

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))    
        {
            onGround = true;
        }

    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            onGround = false;
        }

    }
}

