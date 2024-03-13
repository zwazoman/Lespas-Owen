using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : Attack
{
    [SerializeField] GameObject shootZone;
    public override void Shoot()
    {
        StartCoroutine(EnemyShoot());
    }

    IEnumerator EnemyShoot()
    {
        yield return new WaitForSeconds(rateOfFire);
        Instantiate(bullet, shootZone.transform.position, Quaternion.identity);
        StartCoroutine(EnemyShoot());
    }
}
