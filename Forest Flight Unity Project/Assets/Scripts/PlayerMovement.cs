using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 2;

    private Rigidbody2D physicsBody = null;

    // Start is called before the first frame update
    void Start()
    {

        physicsBody = GetComponent<Rigidbody2D>();

        //physicsBody.velocity = new Vector2(2, 0);

    }

    // Update is called once per frame
    void Update()
    {

        float AxisValY = Input.GetAxis("Vertical");
        float AxisValX = Input.GetAxis("Horizontal");

        //physicsBody.velocity = new Vector2(AxisValX * speed, AxisValY * speed);

    }

}
