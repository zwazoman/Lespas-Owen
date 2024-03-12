using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveProjectile : MonoBehaviour
{
    [SerializeField] 
    private ProjectileClass projectileClass;
    [SerializeField]
    private float projectileSpeed;
    [SerializeField]
    private float scaleProjectile;
    [SerializeField] 
    private int damageProjectile;
    [SerializeField]
    private int timeToLive;
    private Vector2 riffleDirection;

    private void Awake()
    {
        projectileSpeed = projectileClass.speed;
        riffleDirection = projectileClass.shootDirection;
    }
    private void FixedUpdate()
    {
        transform.Translate(riffleDirection * projectileSpeed * Time.deltaTime);
    }

}
