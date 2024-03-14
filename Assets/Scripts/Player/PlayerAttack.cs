using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class PlayerAttack : Attack
{
    [SerializeField] GameObject shootZone;


    public override void Shoot()
    {
        Instantiate(bullet, shootZone.transform.position, Quaternion.identity);

    }

}
