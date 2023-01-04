using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : AbstractBehavior
{

    public float speed = 10f;
    public float runMultiplier = 2f;
    public bool isRunning;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isRunning = false;
        var right = inputState.GetButtonValue(inputButtons[0]);
        var left = inputState.GetButtonValue(inputButtons[1]);
        var run = inputState.GetButtonValue(inputButtons[2]);

        if (right || left)
        {
            var tempSpeed = speed;
            if (run && runMultiplier > 0)
            {
                tempSpeed *= runMultiplier;
                isRunning = true;
            }
            var velX = tempSpeed * (float)inputState.direction;
            rb.velocity = new Vector2(velX, rb.velocity.y);
        }
    }
}
