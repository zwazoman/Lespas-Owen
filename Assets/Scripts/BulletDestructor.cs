using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestructor : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            Destroy(other.gameObject);
            Debug.Log("Super");
        }
    }

    private void Start()
    {
        Destroy(gameObject, 0.1f);
        Debug.Log("Collider détruit");
    }
}
