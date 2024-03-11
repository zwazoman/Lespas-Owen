using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Playercontroller : MonoBehaviour
{
    private PlayerControls playerControls;
    Rigidbody2D rb;
    float moveSpeed;
    [SerializeField] CharacterClass infos;

    private void Awake()
    {
        playerControls = new PlayerControls();
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = infos.speed;
    }
    
    private void OnShoot()
    {
        //Instantiate(infos.bullet);
    }

    private void OnSpecial()
    {

    }

    private void OnMove(InputValue inputValue)
    {
        rb.velocity = inputValue.Get<Vector2>() * moveSpeed;
        print("move");

    }

}
