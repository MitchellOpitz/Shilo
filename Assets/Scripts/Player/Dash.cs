using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : AbstractBehavior
{

    public float dashSpeed = 10f;
    private Rigidbody2D player;
    private bool canDash;
    private float startDashTime;
    public float dashDelay;
    public string dashSound;

    private float xDirection = 0f;
    private float yDirection = 0f;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        collisionState = GetComponent<CollisionState>();
        canDash = true;
    }

    // Update is called once per frame
    void Update()
    {
        var buttonPressed = inputState.GetButtonValue(inputButtons[4]);

        if (buttonPressed && canDash)
        {
            SetDirection();
            // Debug.Log("Dashed | x velocity: " + (xDirection * dashSpeed) + ", y velocity" + (yDirection * dashSpeed));
            player.velocity = new Vector2(xDirection * dashSpeed, yDirection * dashSpeed);
            canDash = false;
            startDashTime = Time.time;
            ToggleScripts(canDash);
            FindObjectOfType<AudioManager>().PlaySound(dashSound);
        }

        if (collisionState.isStanding)
        {
            ResetDash();
        }
    }

    void ResetDash()
    {
        canDash = true;
        ToggleScripts(canDash);
    }

    void SetDirection()
    {
        if (inputState.GetButtonValue(inputButtons[0]))
        {
            yDirection = 1f;
        }
        else if (inputState.GetButtonValue(inputButtons[1]))
        {
            yDirection = -1f;
        }
        else
        {
            yDirection = 0f;
        }

        if (inputState.GetButtonValue(inputButtons[2]))
        {
            xDirection = -1f;
        }
        else if (inputState.GetButtonValue(inputButtons[3]))
        {
            xDirection = 1f;
        }
        else
        {
            xDirection = 0f;
        }
    }
}
