using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKamikazeBehaviour : MonoBehaviour
{
    [SerializeField] EnemyClass infos;
    Rigidbody2D rb;
    float speed;
    int hp;
    Vector3 playerPosition;
    //Vector2 towardsPlayer;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = infos.speed;
        print(speed);
    }

    private void Update()
    {
        playerPosition = Playercontroller.instance.transform.position;
        //towardsPlayer = new Vector2(playerPosition.x - transform.position.x, playerPosition.y - transform.position.y);
        //transform.Translate(towardsPlayer.normalized * speed * Time.deltaTime);
        transform.position = Vector2.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
        transform.up = -(playerPosition - transform.position);
    }

    public void ApplyDamage(int damages)
    {
        print(damages);
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        //animation explosion / vfx ?
    }
}
