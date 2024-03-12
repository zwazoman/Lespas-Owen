using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Behaviour : MonoBehaviour
{
    [SerializeField] EnemyClass infos;
    [SerializeField] Attack attackScript;
    Rigidbody2D rb;
    float speed;
    int hp;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = infos.speed;
        hp = infos.hp;
        attackScript.bullet = infos.bullet;
    }

    private void Start()
    {
        rb.velocity = Vector2.down * speed * Time.deltaTime;
        attackScript.Shoot();
    }
}
