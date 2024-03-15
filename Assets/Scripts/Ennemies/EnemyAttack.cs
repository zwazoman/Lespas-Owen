using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : Attack
{
    [SerializeField] GameObject shootZone;
    [SerializeField] EnemyBehaviour behaviour;
    public override void Shoot()
    {
        StartCoroutine(EnemyShoot());
    }

    IEnumerator EnemyShoot()
    {
;
        Instantiate(behaviour.bullet, shootZone.transform.position, Quaternion.identity);
        //AudioManager.Instance.PlayEnemyShoot();
        yield return new WaitForSeconds(rateOfFire);
        StartCoroutine(EnemyShoot());
    }
}
