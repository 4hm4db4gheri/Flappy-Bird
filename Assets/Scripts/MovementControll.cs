using UnityEngine;

public class MovementControll : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocity = 10f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            rb.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag($"Obstacle") || other.gameObject.CompareTag($"Ground"))
        {
            GameManager.instance.gameOver();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameManager.instance.gotScore();
    }
}
