using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamages : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SendMessage("Damage");
        Destroy(gameObject);
    }
    private void OnDestroy()
    {
        //animation d'explosion
    }
}
