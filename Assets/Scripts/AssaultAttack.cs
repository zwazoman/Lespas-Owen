using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class AssaultAttack : Attack
{
    [SerializeField] GameObject shootZone;
    [SerializeField] GameObject shootZone2;

    public override void Shoot()
    {
        AssaultShoot();
    }
    void AssaultShoot()
    {
        Instantiate(bullet, shootZone.transform.position, Quaternion.identity);
        Instantiate(bullet, shootZone2.transform.position, Quaternion.identity);
    }
}
