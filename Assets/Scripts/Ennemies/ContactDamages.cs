using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactDamages : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 6)
        {
            collision.gameObject.SendMessage("ApplyDamage",3);
            Destroy(gameObject);
        }
    }
}
