using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    // Declare Variables.

    public float speed = 10;
    private Rigidbody2D rb;

    // Start is called before the first frame update.
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame.
    void Update()
    {

        // Obstacles will move at the pace set by the "speed" variable.

        rb.velocity = Vector2.left * speed;

    }
}
