using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;
using TMPro;
using UnityEngine.EventSystems;
using Cinemachine;
using UnityEngine.Networking;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    private PlayerControls playerControls;
    private CinemachineImpulseSource impulseSource;
    Rigidbody2D rb;
    float moveSpeed;
    internal float rateOfFire;
    int hp;
    internal GameObject bullet;
    float cooldown;
    bool hasSpecial = true;
    float cdForText;
    AudioManager audioManager;
    [SerializeField] Collider2D coll;
    [SerializeField] internal CharacterClass infos;
    [SerializeField] Attack attackscript;
    [SerializeField] Animator animator;
    [SerializeField] Super super;
    [SerializeField] GameObject explosion;
    [SerializeField] TMP_Text hpText;
    [SerializeField] TMP_Text cdText;
    [SerializeField] GameObject panelDeath;
    [SerializeField] GameObject switchMenu;
    [SerializeField] GameObject cdPanel;
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
        coll = GetComponent<Collider2D>();
        impulseSource = GetComponent<CinemachineImpulseSource>();
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
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
            StartCoroutine(StartVisualCd());

        }
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
                if (infos.assault) { audioManager.PlaySFX(audioManager.assaultShootSound); }
                else if (infos.rush) { audioManager.PlaySFX(audioManager.rushShootSound); }
                else { AudioManager.Instance.PlaySFX(audioManager.scoutShootSound); }
                attackscript.Shoot(); 
                StartCoroutine(ShootManager());
            }
        }

        hpText.text = hp.ToString();
        cdText.text = cdForText.ToString();
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
        if(hp <= 0)
        {
            Explode();
            Destroy(gameObject);
            panelDeath.SetActive(true);
            EventSystem.current.SetSelectedGameObject(switchMenu);
        }
        audioManager.PlaySFX(audioManager.playerHitSound);
        ShakeManager.instance.CameraShake(impulseSource);
        StartCoroutine(InvincibilityFrames());
    }

    /*IEnumerator HitStop()
    {
        Time.timeScale = 0;
        yield return new WaitForSecondsRealtime(0.3f);
        Time.timeScale = 1;
    }*/
    IEnumerator InvincibilityFrames()
    {
        coll.enabled = false;
        animator.SetBool("DegatsAnim", true);
        yield return new WaitForSeconds(1);
        coll.enabled = true;
        animator.SetBool("DegatsAnim", false);
    }
    private void Explode()
    {
        Instantiate(explosion,transform.position, Quaternion.identity);
        AudioManager.Instance.PlaySFX(AudioManager.Instance.playerDeathSound);
    }

    IEnumerator StartVisualCd()
    {
        cdPanel.SetActive(true);
        cdForText = cooldown;
        while (cdForText > 0f)
        {
            cdForText -= 1f;
            yield return new WaitForSeconds(1f);
           
        }
        cdPanel.SetActive(false);
    }
}
