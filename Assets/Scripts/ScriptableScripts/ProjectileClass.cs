using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Projectile", menuName = "Projectiles")]
public class ProjectileClass : ScriptableObject
{
    [SerializeField]
    internal float speed;
    [SerializeField]
    internal int despawnTime;
}
