using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKamikazeBehaviour : MonoBehaviour
{
    [SerializeField] EnemyClass infos;
    [SerializeField] GameObject explosion;
    Rigidbody2D rb;
    float speed;
    int hp;
    Vector3 playerPosition;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = infos.speed;
        print(speed);
    }

    private void Update()
    {
        if (PlayerController.instance != null)
        {
            playerPosition = PlayerController.instance.transform.position;
            transform.position = Vector2.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
            transform.up = -(playerPosition - transform.position);
        }
    }

    public void ApplyDamage(int damages)
    {
        Explode();
        Destroy(gameObject);
    }

    private void Explode()
    {
        Instantiate(explosion,transform.position,Quaternion.identity);
        AudioManager.Instance.PlaySFX(AudioManager.Instance.enemyDeathSound);
    }
}
