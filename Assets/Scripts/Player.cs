using UnityEngine;

public class Player : MonoBehaviour
{

    public KeyCode moveRight = KeyCode.RightArrow;
    public KeyCode moveLeft = KeyCode.LeftArrow;
    public KeyCode jump = KeyCode.UpArrow;
    public KeyCode fire = KeyCode.Space;
    public float moveSpeed = 5f;
    public float jumpForce = 20f;
    public float boundX = 13.0f;
    public float boundY = 4.5f;

    public GameObject tiroPrefab;
    public Transform firePoint;

    private Rigidbody2D rb;
    private bool isGrounded = true;
    private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isGrounded", isGrounded);
        animator.SetBool("isMoving", false);

        float horizontalDirection = 0.0f;

        if (Input.GetKey(moveRight))
        {
            animator.SetBool("isMoving", true);
            horizontalDirection = 1.0f;
        }
        else if(Input.GetKey(moveLeft))
        {
            animator.SetBool("isMoving", true);
            horizontalDirection = -1.0f;
        }

        if (Input.GetKeyDown(jump) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        var hVelocity = rb.linearVelocity;
        hVelocity.x = horizontalDirection * moveSpeed;
        rb.linearVelocity = hVelocity;

        var hPosition = transform.position;
        hPosition.x = Mathf.Clamp(hPosition.x, -boundX, boundX);
        transform.position = hPosition;

        if (Input.GetKeyDown(fire))
        {
            firePoint = transform.Find("FirePoint");
            Instantiate(tiroPrefab, firePoint.position, Quaternion.identity);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Plataforma"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Plataforma"))
        {
            isGrounded = false;
        }
    }
}
