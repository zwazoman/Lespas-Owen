using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class SuperShield : Super
{
    [SerializeField] GameObject shieldPrefab;
    [SerializeField] GameObject shieldZone;
    GameObject shield;
    
    public override void StartSuper()
    {
        StartCoroutine(StartShield());
    }
    IEnumerator StartShield()
    {
        shield = Instantiate(shieldPrefab, transform);
        yield return new WaitForSeconds(superDuration);
        Destroy(shield);
    }
}
