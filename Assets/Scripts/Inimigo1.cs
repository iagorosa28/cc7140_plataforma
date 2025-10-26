using UnityEngine;

public class Inimigo1 : MonoBehaviour
{
    public Transform target;
    public float moveSpeed = 3.0f;

    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!target) target = GameObject.FindGameObjectWithTag("Player")?.transform;
        if (target)
        {
            Vector2 direction = (target.position - transform.position).normalized;
            rb.linearVelocity = direction * moveSpeed;
        }
    }
}
