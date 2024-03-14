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
        print("chien");
        shield = Instantiate(shieldPrefab, transform);
        Destroy(shield,superDuration) ;
    }
}
