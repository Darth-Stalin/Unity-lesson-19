using System.Collections;
using System.Collections.Generic;
using Player.Inputs;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(Shooter))]
public class PlayerInput : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private Shooter shooter;

    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
        shooter = GetComponent<Shooter>();
    }
    private void Update()
    {
        
        float horizontalDirection = Input.GetAxis(GlobalStringVars.HORIZONTAL_AXIS);
        bool isJumpButtonPressed = Input.GetButtonDown(GlobalStringVars.JUMP);

        if(Input.GetButtonDown(GlobalStringVars.FIRE_1))
            shooter.Shoot(horizontalDirection);

        playerMovement.Move(horizontalDirection, isJumpButtonPressed);
    }
}
