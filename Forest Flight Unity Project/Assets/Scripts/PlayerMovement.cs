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

    // Programmer defined function (not part of Unity).
    // To be called by button.
    // Public = accessible outside of script.
    public void MoveRight()
    {

        // Use the rigidbody, set the velocity to a vector pointing to the right at magnitude of speed.
        physicsBody.velocity = new Vector2(speed, 0);

    }

    public void MoveLeft()
    {

        physicsBody.velocity = new Vector2(-speed, 0);

    }

    public void MoveUp()
    {

        physicsBody.velocity = new Vector2(0, speed);

    }

    public void MoveDown()
    {

        physicsBody.velocity = new Vector2(0, -speed);

    }


}
