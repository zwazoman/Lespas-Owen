using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField] EnemyClass infos;
    [SerializeField] Attack attackScript;
    [SerializeField] GameObject explosion;
    Rigidbody2D rb;
    float speed;
    float rateOfFire;
    int hp;
    internal GameObject bullet;
    SpriteRenderer sprite;


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
        StartCoroutine(ChangeScale());
        if(hp <= 0)
        {
            Explode();
            Destroy(gameObject);
        }
    }

    private void Explode()
    {
        Instantiate(explosion,transform.position, Quaternion.identity);
        //AudioManager.Instance.PlayEnemyDeath();
    }

    IEnumerator ChangeScale()
    {
        transform.localScale *= 1.1f;
        yield return new WaitForSeconds(0.1f);
        transform.localScale /= 1.1f;
    }     
    
}
