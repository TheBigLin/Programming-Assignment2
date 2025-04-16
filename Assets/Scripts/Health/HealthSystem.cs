using UnityEngine.SceneManagement;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth;
    [SerializeField] public GameObject Player;

    private void Awake()
    {
        currentHealth = startingHealth;
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth <= 0)
        {
            GameObject.Destroy(Player);
         
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            TakeDamage(1);
        }
    }


}
