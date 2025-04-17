using System;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Enemy : EnemyBase
{
    public override void TakeDamage(float damage)
    {
        health -= damage;
    }
}
