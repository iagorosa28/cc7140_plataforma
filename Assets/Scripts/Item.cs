using UnityEngine;

public class Item : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            GameManager.AddScore(100);
        }
    }
}
