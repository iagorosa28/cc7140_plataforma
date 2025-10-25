using UnityEngine;
using UnityEngine.Tilemaps;

public class ParallaxTilemap : MonoBehaviour
{
    private float length;
    private float parallaxEffect = 1;
    private float startPosX;
    public float ajustLength = 1;

    void Start()
    {
        startPosX = transform.position.x;
        length = GetComponent<TilemapRenderer>().bounds.size.x;
    }

    void Update()
    {
        transform.position += Vector3.left * parallaxEffect * Time.deltaTime * Parallax.movingSpeed;
        if (transform.position.x <= -27f)
        {
            transform.position += new Vector3((length * ajustLength) * 2.3f, 0f, 0f);
        }
    }
}
