//using System.Threading.Tasks;
using UnityEngine;

public class Tiro : MonoBehaviour
{
    public float speed = 10.0f;
    public float maxDistance = 15.0f;

    private void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        if (Mathf.Abs(transform.position.x) > maxDistance)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Inimigo1"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            GameManager.AddScore(10);
        }
    }
}
