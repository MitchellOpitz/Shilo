using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrictionUpdate : AbstractBehavior
{

    public PhysicsMaterial2D material;
    public float friction = 2f;
    public Jump jump;

    // Start is called before the first frame update
    void Start()
    {
        jump = GetComponent<Jump>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (jump.GetJumping())
        {
            material.friction = 0f;
        } else if (collisionState.isStanding)
        {
            material.friction = friction;
        }
    }
}
