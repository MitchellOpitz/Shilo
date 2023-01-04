using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractBehavior : MonoBehaviour
{

    public Buttons[] inputButtons;
    public MonoBehaviour[] disabledScripts;

    protected InputState inputState;
    protected Rigidbody2D rb;
    protected CollisionState collisionState;

    protected virtual void Awake()
    {
        inputState = GetComponent<InputState>();
        rb = GetComponent<Rigidbody2D>();
        collisionState = GetComponent<CollisionState>();
    }

    protected virtual void ToggleScripts(bool value)
    {
        foreach(var script in disabledScripts)
        {
            script.enabled = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
