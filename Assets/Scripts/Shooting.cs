using UnityEngine;

public class Shooting : MonoBehaviour
{


    public GameObject bulletPrefab;
    public float bulletSpeed = 10f;  // Bullet speed

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouse = Input.mousePosition;
            mouse = Camera.main.ScreenToWorldPoint(mouse);
            mouse.z = 0.0f;


            Vector3 mouseDirection = (mouse - transform.position).normalized;


            Debug.DrawLine(transform.position, transform.position + mouseDirection * 5.0f, Color.red, 1.0f);
            // command to shoot in direction of mouse
            Shoot(mouseDirection);
        }
    }

    void Shoot(Vector3 direction)
    {
        // spawn bullet
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = direction * bulletSpeed;
        GameObject.Destroy(bullet, 1.0f);
    }
}