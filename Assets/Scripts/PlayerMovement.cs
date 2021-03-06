﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame updateü
    public CharacterController controller ; 
    public float speed = 12f;
    public float gravity = -9.81f;

    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask ;

    public LayerMask onGrabbableMask;
     Vector3 velocity ;
     bool isGrounded ;
     bool isOnGrabbable ;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        isGrounded = Physics.CheckSphere(groundCheck.position,groundDistance,groundMask);
        isOnGrabbable = Physics.CheckSphere(groundCheck.position,groundDistance,onGrabbableMask);
        if ((isGrounded && velocity.y < 0) ||(isOnGrabbable && velocity.y<0)) {
            velocity.y  = -2f;

        }
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right*x + transform.forward* z; 
        controller.Move(move*speed*Time.deltaTime);
        if (Input.GetButtonDown("Jump")&& isGrounded||(isOnGrabbable && Input.GetButtonDown("Jump"))) {

            velocity.y = Mathf.Sqrt(jumpHeight*-2f*gravity);
        }

        
        velocity.y += gravity*Time.deltaTime;
        controller.Move(velocity*Time.deltaTime);
    }
}
