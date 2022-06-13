using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    public float speed = 35;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    public void MoveUp()
    {

        rb.velocity = Vector2.up * speed;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

}
