using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Projectile", menuName = "Projectiles")]
public class ProjectileClass : ScriptableObject
{
    [field: SerializeField]
    public float speed { get; private set; }
    [SerializeField]
    public float despawnTime { get; private set; }
}
