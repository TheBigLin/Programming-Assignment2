using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth;
    [SerializeField] private GameObject Player;
    [SerializeField] private string mainMenuSceneName = "MainMenu";
    private void Awake()
    {
        currentHealth = startingHealth;
    }


    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);


        if (currentHealth <= 0)
        {
            Die();
        }
    }

    // Method to handle death
    private void Die()
    {

        Destroy(Player);


        SceneManager.LoadScene(mainMenuSceneName);
    }

    // Collision detection
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Enemy"))
        {
            TakeDamage(1f);
        }

        if (collision.CompareTag("EnemyBullet"))
        {
            TakeDamage(1f);
        }
    }
}

