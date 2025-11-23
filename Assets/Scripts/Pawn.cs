using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;
    public float rollSpeed;
    public float turnSpeed;
    public float turboSpeed;
    public float pitchSpeed;
   

    [Header("Components")]
    public Health health;
    public Death death;
    public Gun gun;
    public Rigidbody Physics;
   
    // Start is called before the first frame update
    void Start()
    {
       // Load the health component from this object
       health = GetComponent<Health>();
       
       // Load the Death component on start
       death = GetComponent<Death>();

       gun = GetComponent<Gun>();

       Physics = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    public void MoveForward ( float moveSpeed)
    {
        // move my pawn forwards
        Physics.AddForce(transform.forward * moveSpeed, ForceMode.Force);
    }
         // moves the pawn backwards
    public void MoveBackward ( float moveSpeed)
    {
        Physics.AddForce(-transform.forward * moveSpeed, ForceMode.Force);
    }
        // rolls the pawn right
    public void RotateClockwise ( float rotateValue)
    {
        Physics.AddTorque(transform.forward * rotateValue, ForceMode.Force);
    }
        // rolls the pawn left
    public void RotateCounterClockwise ( float rotateValue)
    {
        Physics.AddTorque(transform.forward * -rotateValue, ForceMode.Force);
    }
    
       // turns the pawn right
    public void TurnRight ( float turnValue)
    {
        Physics.AddTorque(transform.up * turnValue, ForceMode.Force);
    }

     // turns the pawn left
     public void TurnLeft ( float turnValue)
    {
       Physics.AddTorque(transform.up * -turnValue, ForceMode.Force);
    }

      // pitches the pawn up
    public void PitchUp( float pitchValue)
    {
        Physics.AddTorque(transform.right * -pitchValue, ForceMode.Force);
    }

     //pitches the pawn down
     public void PitchDown( float pitchValue)
    {
        Physics.AddTorque(transform.right * pitchValue, ForceMode.Force);
    }


   
}
