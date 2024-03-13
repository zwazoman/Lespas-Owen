using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKamikazeBehaviour : MonoBehaviour
{
    [SerializeField] EnemyClass infos;
    Rigidbody2D rb;
    float speed;
    int hp;
    Vector2 playerPosition = Playercontroller.instance.transform.position;
    Vector2 towardsPlayer;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = infos.speed;
        hp = infos.hp;
        print(speed);
    }

    private void Update()
    {
        towardsPlayer = new Vector2(playerPosition.x - transform.position.x, playerPosition.y - transform.position.y);
        transform.Translate(towardsPlayer.normalized * speed * Time.deltaTime);
    }
}
