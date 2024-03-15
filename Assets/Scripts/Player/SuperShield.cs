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
        StartShield();
    }
    void StartShield()
    {
        shield = Instantiate(shieldPrefab, transform);
        AudioManager.Instance.PlaySFX(AudioManager.Instance.rushSpecialSound);
        Destroy(shield,superDuration) ;
    }
}
