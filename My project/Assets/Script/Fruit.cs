using UnityEngine;

public class Fruit : MonoBehaviour
{
    Rigidbody2D rb;
    public float score = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("call on earning points with game manager");
        GameManager.Instance.earnScore(score);
        Destroy(this.gameObject);
    }
}
