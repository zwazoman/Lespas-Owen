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
    [SerializeField] Attack Attackscript;
    //[SerializeField] GameObject shootZone;
    //[SerializeField] GameObject shootZone2;

    private void Awake()
    {
        playerControls = new PlayerControls();
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = infos.speed;
        Attackscript.bullet = infos.bullet;
    }
    
    private void OnShoot()
    {
        //StartCoroutine(SwitchCanon());
        Attackscript.Shoot();
    }

    private void OnSpecial()
    {

    }

    private void OnMove(InputValue inputValue)
    {
        rb.velocity = inputValue.Get<Vector2>() * moveSpeed;
        print("move");

    }


    /*IEnumerator SwitchCanon()
    {
        Instantiate(infos.bullet, shootZone.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(0.1f);
        Instantiate(infos.bullet, shootZone2.transform.position, Quaternion.identity);
    }*/

}
