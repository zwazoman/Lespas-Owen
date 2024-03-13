using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class Playercontroller : MonoBehaviour
{
    public static Playercontroller instance;

    private PlayerControls playerControls;
    Rigidbody2D rb;
    float moveSpeed;
    float rateOfFire;
    int hp;
    [SerializeField] CharacterClass infos;
    [SerializeField] Attack attackscript;
    [SerializeField] Animator animator;
    private Vector3 mouvement;
    internal Vector2 InputValue;
    private bool isStickUse = false;
    private bool spaceHold = false;
    private bool canShoot = true;
    private void Awake()
    {
        instance = this;
        playerControls = new PlayerControls();
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = infos.speed;
        attackscript.bullet = infos.bullet;
        rateOfFire = infos.rateOfFire;
        attackscript.rateOfFire = rateOfFire;
        hp = infos.hp;
    }

    public void OnShoot(InputAction.CallbackContext value)
    {
        if(value.performed)
        {
            spaceHold = true; 
        }
        else if (value.canceled)
        {
            spaceHold = false;
        }
    }

    private void OnSpecial()
    {

    }

    public void OnMove(InputAction.CallbackContext callbackContext)
    {
        if (callbackContext.started)
        {
            isStickUse = true;
        }
        if (callbackContext.canceled)
        {
            isStickUse = false;
        }
        Vector2 orientation = callbackContext.ReadValue<Vector2>();
        mouvement = new Vector3(InputValue.x, 0, InputValue.y);
        mouvement.x += orientation.x;
        mouvement.y += orientation.y;
        mouvement.z = 0;
        mouvement.Normalize();
        animator.SetFloat("VelocityR",mouvement.x);

    }

    private void FixedUpdate()
    {
        if (isStickUse)
        {
            transform.position = transform.position + (moveSpeed * mouvement * Time.deltaTime);
        }
    }

    private void Update()
    {
        if (spaceHold)
        {
            if (canShoot == true) 
            { 
            attackscript.Shoot();
            StartCoroutine(ShootManager());
            }
        }
    }
    
    IEnumerator ShootManager()
    {
        canShoot = false;
        yield return new WaitForSeconds(rateOfFire);
        canShoot = true;       
    }

    public void Damage()
    {
        hp -= 1;
        print(hp);
        if(hp == 0)
        {
            Death();
        }
    }

    private void Death()
    {
        print("t'es mort");
        //panel mort
        Destroy(gameObject);
    }
}
