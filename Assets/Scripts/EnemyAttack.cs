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
        yield return new WaitForSeconds(2);
        Instantiate(bullet, shootZone.transform.position, Quaternion.identity);
        EnemyShoot();
    }
}
