using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class PlayerAttack : Attack
{
    [SerializeField] GameObject shootZone;
    [SerializeField] PlayerController controller;


    public override void Shoot()
    {
        Instantiate(controller.bullet, shootZone.transform.position, Quaternion.identity);

    }

}
