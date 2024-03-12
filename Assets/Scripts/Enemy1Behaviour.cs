using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Behaviour : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] EnemyClass infos;
    Rigidbody2D rb;
    float speed;
    int hp;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = infos.speed;
        hp = infos.hp;
    }

    private void Start()
    {
        rb.velocity = Vector2.down * speed * Time.deltaTime;
    }
}
