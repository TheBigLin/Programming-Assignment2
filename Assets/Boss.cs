using UnityEngine;

public class Boss: MonoBehaviour
{
    public float startingHealth = 100f;
    private float currentHealth;

    public float moveSpeed = 2f;
    public float HalfHealthSpeed = 4f; // Speed when health is in 2nd phase

    private Transform player; // reference to player
    void Start()
    {
        currentHealth = startingHealth;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {

        if (player != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, IntenseMoveSpeed() * Time.deltaTime);
        }
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private float IntenseMoveSpeed()
    {
        if (currentHealth <= startingHealth / 2)
            return HalfHealthSpeed;
        else
            return moveSpeed;
    }

    private void Die()
    {
        Destroy(gameObject);
 // YAY YOU WIN
    }
}      
        
 