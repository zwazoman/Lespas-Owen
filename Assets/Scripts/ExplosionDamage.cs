using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionDamage : MonoBehaviour
{
    [SerializeField] int damages;
    Collider2D coll;

    private void Awake()
    {
        coll = GetComponent<Collider2D>();
        Destroy(coll,0.5f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer != 8)
        {
        collision.gameObject.SendMessage("ApplyDamage", damages);
        }
    }
}
