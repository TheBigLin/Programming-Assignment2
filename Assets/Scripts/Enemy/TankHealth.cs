using UnityEngine;

public class TankHealth : EnemyBase // armored target
{
    public override void TakeDamage(float damage)
    {
        health -= damage * 0.5f;
    }
}
