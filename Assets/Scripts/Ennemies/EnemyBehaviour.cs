using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField] EnemyClass infos;
    [SerializeField] Attack attackScript;
    Rigidbody2D rb;
    float speed;
    float rateOfFire;
    int hp;
    internal GameObject bullet;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = infos.speed;
        hp = infos.hp;
        rateOfFire = infos.rateOfFire;
        bullet = infos.bullet;
        attackScript.rateOfFire = rateOfFire;
    }

     IEnumerator Start()
    {
        rb.velocity = Vector2.left * speed;
        yield return new WaitForSeconds(1);
        attackScript.Shoot();
    }

    public void ApplyDamage(int damages)
    {
        hp -= damages;
        if(hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        //animation de mort
        print("destroyed");
    }
}
