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

    private void Awake()
    {
        projectileSpeed = projectileClass.speed;
    }
    private void FixedUpdate()
    {
        transform.Translate(Vector2.up * projectileSpeed * Time.deltaTime);
    }

}
