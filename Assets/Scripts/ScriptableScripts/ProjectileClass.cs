using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Projectile", menuName = "Projectiles")]
public class ProjectileClass : ScriptableObject
{
    [field: SerializeField]
    public float speed { get; private set; }

    [field: SerializeField]
    public float despawnTime { get; private set; }

    [field: SerializeField]
    public int damages { get;private set; }

    [field: SerializeField]
    public Vector2 direction { get; private set;}
}
