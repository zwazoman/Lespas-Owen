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
    [SerializeField] CharacterClass infos;
    [SerializeField] Attack attackscript;
    //[SerializeField] GameObject shootZone;
    //[SerializeField] GameObject shootZone2;
    [SerializeField] Animator animator;
    private void Awake()
    {
        instance = this;
        playerControls = new PlayerControls();
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = infos.speed;
        attackscript.bullet = infos.bullet;
    }
    
    private void OnShoot()
    {
        //StartCoroutine(SwitchCanon());
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


    /*IEnumerator SwitchCanon()
    {
        Instantiate(infos.bullet, shootZone.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(0.1f);
        Instantiate(infos.bullet, shootZone2.transform.position, Quaternion.identity);
    }*/

}
