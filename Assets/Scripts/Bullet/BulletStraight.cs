using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletStraight : MonoBehaviour
{
    [SerializeField]
    private ProjectileClass infos;
    private float projectileSpeed;
    private float despawnTime;
    Vector2 direction;


    private void Awake()
    {
        projectileSpeed = infos.speed;
        despawnTime = infos.despawnTime;
        direction = infos.direction;
        Destroy(gameObject, despawnTime);
    }

    private void FixedUpdate()
    {
        transform.Translate(direction * projectileSpeed * Time.deltaTime);
    }
}
