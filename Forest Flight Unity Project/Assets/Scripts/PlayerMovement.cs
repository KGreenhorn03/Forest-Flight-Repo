using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D physicsBody = null;

    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {

        physicsBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown(buttonName: "Jump"))
        {

            physicsBody.velocity = new Vector2(0, speed);

        }

    }
}
