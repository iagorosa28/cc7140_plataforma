using UnityEngine;
using UnityEngine.Tilemaps;

public class ParallaxVoadora : MonoBehaviour
{
    public float parallaxEffect = 1;
    private float dir = -1f;

    void Update()
    {
        transform.position += Vector3.right * parallaxEffect * Time.deltaTime * Parallax.movingSpeed * dir;
        if (transform.position.x <= -10f || transform.position.x >= 10f)
        {
            dir = dir * -1f;
        }
    }
}
