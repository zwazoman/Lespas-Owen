using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Projectile", menuName = "Projectiles")]
public class ProjectileClass : ScriptableObject
{
    [SerializeField]
    internal float speed;
    [SerializeField]
    internal float scale;
    [SerializeField]
    internal int damages;
    [SerializeField]
    internal int timeToScreen;
}
