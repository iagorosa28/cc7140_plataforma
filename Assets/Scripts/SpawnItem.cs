using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    public GameObject itemPrefab;
    public Transform point;

    private float timer = 0.0f;
    public float waitTime = 10.0f;

    private GameObject currentItem;

    private void Start()
    {
        currentItem = Instantiate(itemPrefab, point.position, Quaternion.identity);
    }

    private void Update()
    {
        if (currentItem == null)
        {
            timer += Time.deltaTime;
            if (timer >= waitTime)
            {
                timer = 0.0f;
                currentItem = Instantiate(itemPrefab, point.position, Quaternion.identity);
            }
        }
    }
}
