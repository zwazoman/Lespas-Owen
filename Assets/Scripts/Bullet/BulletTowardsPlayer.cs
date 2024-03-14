using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletTowardsPlayer : MonoBehaviour
{
    [SerializeField] private ProjectileClass projectileClass;
    [SerializeField] GameObject explosion;
    private float projectileSpeed;
    private float despawnTime;
    private Vector2 playerPosition;
    private Vector2 towardsPlayer;

    private IEnumerator Start()
    {
        if (PlayerController.instance != null) { 
            playerPosition = PlayerController.instance.transform.position;
            projectileSpeed = projectileClass.speed;
            despawnTime = projectileClass.despawnTime;
            towardsPlayer = new Vector2(playerPosition.x - transform.position.x, playerPosition.y - transform.position.y);
            yield return new WaitForSeconds(despawnTime);
            Explode();
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        transform.Translate(towardsPlayer.normalized * projectileSpeed * Time.deltaTime);
    }

    void Explode()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
    }
}
