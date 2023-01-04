using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : AbstractBehavior
{
    public float jumpSpeed = 200f;
    public float jumpDelay = 0.1f;
    public int jumpCount = 2;
    public GameObject jumpEffectPrefab;
    public string jumpSound;

    protected float lastJumpTime = 0;
    protected int jumpsRemaining = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var canJump = inputState.GetButtonValue(inputButtons[0]);
        var holdTime = inputState.GetButtonHoldTime(inputButtons[0]);

        if (collisionState.isStanding)
        {
            if (canJump && holdTime < .1f)
            {
                jumpsRemaining = jumpCount - 1;
                OnJump();
            }
        } else
        {

            if (canJump && holdTime < .1f && Time.time - lastJumpTime > jumpDelay)
            {
                if (jumpsRemaining > 0)
                {
                    OnJump();
                    jumpsRemaining--;
                    if(jumpEffectPrefab != null)
                    {
                        var clone = Instantiate(jumpEffectPrefab);
                        clone.transform.position = transform.position;
                    }
                }
            }
        }
    }

    protected virtual void OnJump()
    {
        var vel = rb.velocity;
        lastJumpTime = Time.time;
        rb.velocity = new Vector2(vel.x, jumpSpeed);
        FindObjectOfType<AudioManager>().PlaySound(jumpSound);
    }

    public float GetLastJumpTime()
    {
        return lastJumpTime;
    }
}
