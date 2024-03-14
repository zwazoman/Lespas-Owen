using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletTowardsPlayer : MonoBehaviour
{
    [SerializeField] 
    private ProjectileClass projectileClass;
    private float projectileSpeed;
    private float despawnTime;
    private Vector2 playerPosition;
    private Vector2 towardsPlayer;

    private void Awake()
    {
        if (PlayerController.instance != null) { 
            playerPosition = PlayerController.instance.transform.position;
            projectileSpeed = projectileClass.speed;
            despawnTime = projectileClass.despawnTime;
            Destroy(gameObject, despawnTime);
            towardsPlayer = new Vector2(playerPosition.x - transform.position.x, playerPosition.y - transform.position.y);
        }
    }
    private void Update()
    {
        transform.Translate(towardsPlayer.normalized * projectileSpeed * Time.deltaTime);
    }

}
