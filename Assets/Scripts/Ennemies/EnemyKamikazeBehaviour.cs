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

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = infos.speed;
        print(speed);
    }

    private void Update()
    {
        playerPosition = PlayerController.instance.transform.position;
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
