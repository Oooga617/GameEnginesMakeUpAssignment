using UnityEngine;

public class SnakeController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody2D rb;
    public float speed = 15f;
    bool isDead = false;
    Vector2 dir = new Vector2();
    float moveX = 1.0f, moveY = 0.0f;
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("border"))
        {
            playerDeath();
        }
        
            
    }

    void playerDeath()
    {
        Debug.Log("supposed to kill player");
        GameManager.Instance.showRetry();
        Destroy(this.gameObject);
    }
}
