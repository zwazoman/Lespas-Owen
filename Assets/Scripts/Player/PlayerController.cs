using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    private PlayerControls playerControls;
    Rigidbody2D rb;
    float moveSpeed;
    internal float rateOfFire;
    int hp;
    internal GameObject bullet;
    float cooldown;
    bool hasSpecial = true;
    [SerializeField] internal CharacterClass infos;
    [SerializeField] Attack attackscript;
    [SerializeField] Animator animator;
    [SerializeField] Super super;
    [SerializeField] GameObject explosion;
    [SerializeField] TMP_Text hpText;
    [SerializeField] TMP_Text cdText;
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
        rateOfFire = infos.rateOfFire;
        attackscript.rateOfFire = rateOfFire;
        hp = infos.hp;
        cooldown = infos.cooldown;
        bullet = infos.bullet;
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

    public void OnSpecial(InputAction.CallbackContext callback)
    {
        if (hasSpecial)
        {
            super.StartSuper();
            hasSpecial = false;
            StartCoroutine(StartSpecialCooldown());
        }
        Debug.Log("feur"); 
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
        animator.SetFloat("VelocityR",mouvement.y);

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

        hpText.text = hp.ToString();
        cdText.text = cooldown.ToString();
    }
    
    IEnumerator ShootManager()
    {
        canShoot = false;
        yield return new WaitForSeconds(rateOfFire);
        canShoot = true;       
    }

    IEnumerator StartSpecialCooldown()
    {
        yield return new WaitForSeconds(cooldown);
        hasSpecial = true;
    }
    public void ApplyDamage(int damages)
    {
        hp -= damages;
        print(hp);
        if(hp <= 0)
        {
            Explode();
            Destroy(gameObject);
        }
    }
    private void Explode()
    {
        Instantiate(explosion,transform.position, Quaternion.identity);
    }
}
