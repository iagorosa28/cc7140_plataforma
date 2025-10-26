using UnityEngine;

public class Inimigo1Damage : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(transform.root.gameObject);         // destr�i o inimigo
            Destroy(other.gameObject);                  // destr�i o Player
        }
    }
}
