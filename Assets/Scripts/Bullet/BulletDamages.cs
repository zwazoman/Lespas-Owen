using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamages : MonoBehaviour
{
    [SerializeField] ProjectileClass infos;
    [SerializeField] GameObject explosion;
    int damages;

    private void Awake()
    {
        damages = infos.damages;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Shield")
        {
            collision.gameObject.SendMessage("ApplyDamage",damages);
        }
        Explode();
        Destroy(gameObject);
    }
    private void Explode()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        AudioManager.Instance.PlaySFX(AudioManager.Instance.bulletHitSound);
    }
}
