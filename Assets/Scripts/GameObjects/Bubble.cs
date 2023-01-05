using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Transform player;

    Vector2 moveDirection;
    public Rigidbody2D rb;
    Directions direction;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (player)
        {
            Vector3 newPosition = player.position;
            direction = player.GetComponent<InputState>().direction;
            if (direction == Directions.Right)
            {
                newPosition.x = player.position.x - 1f;
            } else
            {

                newPosition.x = player.position.x + 1f;
            }

            moveDirection = (newPosition - transform.position).normalized;
        }
    }

    private void FixedUpdate()
    {
       if (player)
        {
            rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * moveSpeed;
        }
    }
}
