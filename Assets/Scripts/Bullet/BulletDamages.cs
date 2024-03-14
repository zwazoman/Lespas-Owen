using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamages : MonoBehaviour
{
    [SerializeField] ProjectileClass infos;
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
        Destroy(gameObject);
    }
    private void OnDestroy()
    {
        //animation d'explosion
    }
}
