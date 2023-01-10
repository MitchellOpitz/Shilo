using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterInteraction : MonoBehaviour
{
    public Rigidbody2D rb;
    private float gravity;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gravity = rb.gravityScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.tag == "Water")
        {
            rb.gravityScale = gravity / 2;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Water")
        {
            rb.gravityScale = gravity;
        }
    }
}
