using UnityEngine;

public class ParallaxA : MonoBehaviour
{
    private float length;
    public float parallaxEffect;
    public static float movingSpeed = 5f;
    private float startPosX;

    void Start()
    {
        startPosX = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        transform.position += Vector3.left * parallaxEffect * Time.deltaTime * movingSpeed;
        if (transform.position.x <= startPosX -length)
        {
            transform.position += new Vector3(length * 1f, 0f, 0f);
        }
    }
}
