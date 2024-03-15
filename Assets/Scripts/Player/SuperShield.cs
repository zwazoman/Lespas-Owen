using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class SuperShield : Super
{
    [SerializeField] GameObject shieldPrefab;
    GameObject shield;
    
    public override void StartSuper()
    {
        StartCoroutine(StartShield());
    }
    IEnumerator StartShield()
    {
        shield = Instantiate(shieldPrefab, transform);
        AudioManager.Instance.PlaySFX(AudioManager.Instance.rushSpecialSound);
        yield return new WaitForSeconds(superDuration);
        AudioManager.Instance.PlaySFX(AudioManager.Instance.rushSpecialSound);
        Destroy(shield);
    }
}
