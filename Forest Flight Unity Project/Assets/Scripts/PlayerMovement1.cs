using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{

    public float speed = 2;

    private Rigidbody2D physicsBody = null;

    // Start is called before the first frame update
    void Start()
    {

        physicsBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float axisValY = Input.GetAxis("Vertical");

    }
}
