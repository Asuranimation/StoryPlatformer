using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : PhysicsObject
{
    [SerializeField] private float maxSpeed = 1;
    [SerializeField] private float jumpPower;
    void Start()
    {
        
    }

    void Update()
    {
        targetVelocity = new Vector2(Input.GetAxis("Horizontal") * maxSpeed,0);
        
        // if the player presses "jump" and we are in grounded, set the velocity a ajump power value
        if (Input.GetButtonDown("Jump") && grounded)
        {
            velocity.y = jumpPower;
        }
    }
}
