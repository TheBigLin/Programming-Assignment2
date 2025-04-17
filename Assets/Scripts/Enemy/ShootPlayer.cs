using UnityEngine;

public class ShootPlayer : MonoBehaviour
{
    public GameObject bulletPrefab; //bullet refernece for the enemy
    public Transform firePoint; // where the enemy will shoot from (in front)
    public float shootingRange = 5f; // distance where activated
    public float fireRate = 1f; // shooting speed
    private float fireTimer = 0f; // how long till next shot
    private Transform player; // player refernece
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform; // find the player to aim at
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null) return;

        float distance = Vector2.Distance(transform.position, player.position); // checks how far away player is
        fireTimer += Time.deltaTime;

        if (distance <= shootingRange && fireTimer >= 1f / fireRate) // if player is within the shooting range, and is able to shoot, then use the shoot() function
        {
            Shoot();
            fireTimer = 0f;
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        Vector2 direction = (player.position - firePoint.position).normalized;
        bullet.GetComponent<Rigidbody2D>().velocity = direction * 10f; // 10 is bullet speed
        GameObject.Destroy(bullet, 1.0f);
    }
}