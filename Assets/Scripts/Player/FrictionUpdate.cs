using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrictionUpdate : AbstractBehavior
{

    public PhysicsMaterial2D material;
    public float friction = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (collisionState.onWall)
        {
            material.friction = 0f;
        } else if (collisionState.isStanding)
        {
            material.friction = friction;
        }
    }
}
