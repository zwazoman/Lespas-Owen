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
        StartCoroutine(SwitchCanon());
    }
    IEnumerator SwitchCanon()
    {
        Instantiate(bullet, shootZone.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(0.1f);
        Instantiate(bullet, shootZone2.transform.position, Quaternion.identity);
    }
}
