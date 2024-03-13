using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Behaviour : MonoBehaviour
{
    [SerializeField] EnemyClass infos;
    [SerializeField] Attack attackScript;
    Rigidbody2D rb;
    float speed;
    float rateOfFire;
    int hp;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = infos.speed;
        hp = infos.hp;
        rateOfFire = infos.rateOfFire;
        attackScript.bullet = infos.bullet;
        attackScript.rateOfFire = rateOfFire;
    }

    private void Start()
    {
        rb.velocity = Vector2.down * speed * Time.deltaTime;
        attackScript.Shoot();
    }
}
