using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float speed = 3.0f;
    private Transform player;

    void Start()
    {
        // Find the player by tag
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (player != null)
        {
            // Move towards the player
            Vector2 direction = (player.position - transform.position).normalized;
            transform.position += (Vector3)(direction * speed * Time.deltaTime);
        }
    }
}
