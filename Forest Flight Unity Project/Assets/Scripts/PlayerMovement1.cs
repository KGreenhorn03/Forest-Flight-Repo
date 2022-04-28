using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{

    private Rigidbody2D rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();

    }

    public void MoveUp()
    {

        rb.velocity = Vector2.up * speed;

    }

}
