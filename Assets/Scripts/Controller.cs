using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Pawn pawn;

    public CameraTracking camera;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Based on inputs, send commands to Pawn
        MoveIt();
    }

    private void MoveIt()
    {

        if (pawn == null) return ;
        
        if( Input.GetKey(KeyCode.W))
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            pawn.MoveForward(pawn.turboSpeed);
        }
        else
        {
            // Tell Pawn to move Forward
            pawn.MoveForward( pawn.moveSpeed);
        }
    }
        if( Input.GetKey(KeyCode.S))
        {
            // Tell Pawn to move Backward
            pawn.MoveBackward(pawn.moveSpeed);
        }
        if( Input.GetKey(KeyCode.E))
        {
            // Tell Pawn to roll clockwise
            pawn.RotateCounterClockwise( pawn.rollSpeed);
        }
         if( Input.GetKey(KeyCode.Q))
        {
            // Tell Pawn to roll counterclockwise
            pawn.RotateClockwise( pawn.rollSpeed);
        }
        if( Input.GetKey(KeyCode.D))
        {   
            // turns pawn right
            pawn.TurnRight(pawn.turnSpeed);
        }
        if( Input.GetKey(KeyCode.A))
        {
            // turns pawn left
            pawn.TurnLeft(pawn.turnSpeed);
        }
        if( Input.GetKey(KeyCode.Z))
        {
            // pitches pawn down
            pawn.PitchDown(pawn.pitchSpeed);
        }
        if( Input.GetKey(KeyCode.X))
        {
            // pitches pawn up
            pawn.PitchUp(pawn.pitchSpeed);
        }
        if( Input.GetKeyDown(KeyCode.Space))
        {
            // makes gun shoot
            pawn.gun.Shoot();
        }
        if( Input .GetKey(KeyCode.O))
        {
            // zooms camera in
            camera.ZoomIn();
        }
        if( Input .GetKey(KeyCode.L))
        {
            // zooms camera out
            camera.ZoomOut();
        }





    }
}
