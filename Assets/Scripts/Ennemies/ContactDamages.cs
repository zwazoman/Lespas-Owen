using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactDamages : MonoBehaviour
{
    [SerializeField] GameObject explosion;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 6)
        {
            collision.gameObject.SendMessage("ApplyDamage",3);
            Explode();
            Destroy(gameObject);
        }
    }
    
    void Explode()
    {
        gameObject.SendMessage("ApplyDamage", 100);
    }
}
