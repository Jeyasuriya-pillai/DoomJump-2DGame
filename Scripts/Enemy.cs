using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f;
    public Transform[] points;

    private int i;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (points.Length > 0) transform.position = points[0].position;
    }

    void Update()
    {
        if (points.Length == 0) return;

        // Switch target point when close enough
        if (Vector2.Distance(transform.position, points[i].position) < 0.25f)
        {
            i = (i + 1) % points.Length;
        }

        // Move towards current target
        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);

        // Flip the sprite automatically based on movement direction
        spriteRenderer.flipX = (transform.position.x - points[i].position.x) < 0f;
    }
}