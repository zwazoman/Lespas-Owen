using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Playercontroller : MonoBehaviour
{
    public static Playercontroller instance;

    private PlayerControls playerControls;
    Rigidbody2D rb;
    float moveSpeed;
    float rateOfFire;
    [SerializeField] CharacterClass infos;
    [SerializeField] Attack attackscript;
    [SerializeField] Animator animator;
    private void Awake()
    {
        instance = this;
        playerControls = new PlayerControls();
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = infos.speed;
        attackscript.bullet = infos.bullet;
        rateOfFire = infos.rateOfFire;
        attackscript.rateOfFire = rateOfFire;
    }
    
    private void OnShoot()
    {
        attackscript.Shoot();
    }

    private void OnSpecial()
    {

    }

    private void OnMove(InputValue inputValue)
    {
        rb.velocity = inputValue.Get<Vector2>() * moveSpeed;
        print("move");
        animator.SetFloat("VelocityR", rb.velocity.x);
    }
}
