using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamagesThrough : MonoBehaviour
{
    [SerializeField] ProjectileClass infos;
    int damages;

    private void Awake()
    {
        damages = infos.damages;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SendMessage("ApplyDamage",damages) ;
        AudioManager.Instance.PlaySFX(AudioManager.Instance.bulletHitSound);
    }
}
