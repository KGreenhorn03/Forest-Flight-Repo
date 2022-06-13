using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{

    public float speed = 10;
    private Rigidbody2D rb;
    public int score;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        rb.velocity = Vector2.left * speed;

        if (score >= 10)
        {

            speed = 12;

        }

    }
}
