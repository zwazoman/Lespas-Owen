using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    Rigidbody2D rb;
    float speed;
    [SerializeField] CharacterClass infos;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = infos.speed;
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 direction = new Vector2(x, y);
        rb.velocity = direction * speed * Time.fixedDeltaTime;
    }
   
}
