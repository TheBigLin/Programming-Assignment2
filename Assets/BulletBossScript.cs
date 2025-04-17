using UnityEngine;

public class BulletBossScript : MonoBehaviour
{
    public float damage = 10f;
    public float lifeTime = 3f; 

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<HealthSystem>()?.TakeDamage(damage);

         //   GameObject.Destroy(bullet, 5.0f);
        }
    }
}