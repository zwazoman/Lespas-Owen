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

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = infos.speed;
        hp = infos.hp;
        rateOfFire = infos.rateOfFire;
        attackScript.bullet = infos.bullet;
        attackScript.rateOfFire = rateOfFire;
    }

     IEnumerator Start()
    {
        rb.velocity = Vector2.left * speed * Time.deltaTime;
        yield return new WaitForSeconds(2);
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
