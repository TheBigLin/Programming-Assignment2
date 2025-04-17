using UnityEngine;

public class DamageBoss : MonoBehaviour
{
    public float damage = 2f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Boss"))
        {
            Boss boss = collision.GetComponent<Boss>();
            if (boss != null)
            {
                boss.TakeDamage(damage); // take the damage 
            }

            Destroy(gameObject); // Destroy the bullet after it hits
        }
    }
}