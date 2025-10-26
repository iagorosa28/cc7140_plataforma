using UnityEngine;

public class Inimigo1Damage : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(transform.root.gameObject);         // destrói o inimigo
            GameManager.LoseLife(1);
        }
    }
}
