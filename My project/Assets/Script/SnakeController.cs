using UnityEngine;

public class SnakeController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody2D rb;
    public float speed = 15f;
    bool isDead = false;
    Vector2 dir = new Vector2();
    float moveX, moveY;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            moveX = 0;
            moveY = 1;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            moveX = -1;
            moveY = 0;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            moveX = 0;
            moveY = -1;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            moveX = 1;
            moveY = 0;
        }

        dir = new Vector2(moveX, moveY);
        

    }

    private void FixedUpdate()
    {
        rb.AddForce(dir);
    }
}
