using UnityEngine;

public class Parallax : MonoBehaviour
{
    public static float movingSpeed = 5f;

    private float length;
    private float parallaxEffect = 1;
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
