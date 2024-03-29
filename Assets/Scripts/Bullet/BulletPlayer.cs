using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletTowardsRight : MonoBehaviour
{
    [SerializeField] 
    private ProjectileClass projectileClass;
    private float projectileSpeed;
    private float despawnTime;


    private void Awake()
    {
        projectileSpeed = projectileClass.speed;
        despawnTime = projectileClass.despawnTime;
        Destroy(gameObject, despawnTime);
    }
    private void FixedUpdate()
    {
        transform.Translate(Vector2.right * projectileSpeed * Time.deltaTime);
    }

}
