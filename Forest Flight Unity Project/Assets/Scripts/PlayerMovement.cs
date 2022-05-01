using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    public float speed = 35;
    private int score;
    public TextMeshProUGUI scoreDisplay;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    public void MoveUp()
    {

        rb.velocity = Vector2.up * speed;

    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        score++;
        scoreDisplay.text = score.ToString();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

}
