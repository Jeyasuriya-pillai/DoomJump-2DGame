using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed = 2f;
    public Transform[] points; 
    private int i; 

    void Start()
    {
        if (points.Length > 0) transform.position = points[0].position;
    }

    void Update()
    {
        if (points.Length == 0) return;

        // If arrived at the current target point, move to the next index (loops back to 0 automatically)
        if (Vector2.Distance(transform.position, points[i].position) < 0.01f)
        {
            i = (i + 1) % points.Length;
        }

        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) collision.transform.SetParent(transform);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) collision.transform.SetParent(null);
    }
}