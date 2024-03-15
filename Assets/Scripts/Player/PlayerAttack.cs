using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : Attack
{
    [SerializeField] GameObject shootZone;
    [SerializeField] PlayerController controller;
    [SerializeField] CharacterClass ship;


    public override void Shoot()
    {
        Instantiate(controller.bullet, shootZone.transform.position, Quaternion.identity);
    }

}
