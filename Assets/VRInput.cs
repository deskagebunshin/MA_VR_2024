using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRInput : MonoBehaviour
{
    [Header("Character Input Values")]
    public Vector2 move;
    public Vector2 look;
    public bool jump;
    public bool sprint;

    [Header("Movement Settings")]
    public bool analogMovement;


    private void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        
        Vector2 leftThumbstick = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
        move = leftThumbstick;
    }

    public void MoveInput(Vector2 newMoveDirection)
    {
        move = newMoveDirection;
    } 

    public void LookInput(Vector2 newLookDirection)
    {
        look = newLookDirection;
    }

    public void JumpInput(bool newJumpState)
    {
        jump = newJumpState;
    }

    public void SprintInput(bool newSprintState)
    {
        sprint = newSprintState;
    }

}
