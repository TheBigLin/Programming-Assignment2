using UnityEngine;

public class Enemy : EnemyBase
{
    public override void TakeDamage(float damage)
    {
        health -= damage;
    }
}
