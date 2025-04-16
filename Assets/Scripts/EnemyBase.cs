using UnityEngine;
using UnityEngine.UI;
public abstract class EnemyBase : MonoBehaviour
{
    protected float health = 100.0f;

    public abstract void TakeDamage(float damage);

    void OnTriggerEnter2D(Collider2D collision)
    {
        Bullets bullets = collision.GetComponent<Bullets>();
        TakeDamage(bullets.damage);
        if (health <= 0.0f)
            Destroy(gameObject);            // Destroy the target
        Destroy(collision.gameObject);      // Destroy the bullet
    }
}
