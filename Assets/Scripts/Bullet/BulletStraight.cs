using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletStraight : MonoBehaviour
{
    [SerializeField] private ProjectileClass infos;
    [SerializeField] GameObject explosion;
    private float projectileSpeed;
    private float despawnTime;
    Vector2 direction;


    private IEnumerator Start()
    {
        projectileSpeed = infos.speed;
        despawnTime = infos.despawnTime;
        direction = infos.direction;
        yield return new WaitForSeconds(despawnTime);
        Explode();
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Translate(direction * projectileSpeed * Time.deltaTime);
    }

    void Explode()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
    }
}
