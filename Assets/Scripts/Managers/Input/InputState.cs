using System.Collections.Generic;
using UnityEngine;

// Used by InputManager (set in inspector).
public class InputState : MonoBehaviour
{
    public Directions direction = Directions.Right;
    public float absVelX = 0f;
    public float absVelY = 0f;
    private Rigidbody2D rb;

    private Dictionary<Buttons, ButtonState> buttonStates = new Dictionary<Buttons, ButtonState>();

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void FixedUpdate()
    {
        absVelX = Mathf.Abs(rb.velocity.x);
        absVelY = Mathf.Abs(rb.velocity.y);
    }

    public void SetButtonValue(Buttons key, bool value)
    {
        if (!buttonStates.ContainsKey(key))
            buttonStates.Add(key, new ButtonState());

        var state = buttonStates[key];

        if (state.beingPressed && !value)
        {
            state.holdTime = 0;
        } else if (state.beingPressed && value)
        {
            state.holdTime += Time.deltaTime;
        }
        state.beingPressed = value;
    }

    // Checks if a button 
    public bool GetButtonValue(Buttons key)
    {
        if (buttonStates.ContainsKey(key))
            return buttonStates[key].beingPressed;
        else
            return false;
    }

    // Checks if a button 
    public float GetButtonHoldTime(Buttons key)
    {
        if (buttonStates.ContainsKey(key))
            return buttonStates[key].holdTime;
        else
            return 0;
    }
}
