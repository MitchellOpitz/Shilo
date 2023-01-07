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
    void Update()
    {
        if (collisionState.isStanding)
        {
            Debug.Log("standing");
            material.friction = friction;
        } else
        {
            Debug.Log("Jumping");
            material.friction = 0f;
        }
    }
}
