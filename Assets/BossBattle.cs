using UnityEngine;

public class BossBattle : MonoBehaviour
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

    // Update is called once per frame
    void Update()
    {

        if (player != null)
        {
           
        }
    }
}