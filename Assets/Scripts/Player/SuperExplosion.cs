using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class SuperExplosion : Super
{
    [SerializeField] CharacterClass infos;
    float rateOfFire;
    
    public override void StartSuper()
    {
        Explosion();
    }
    void Explosion()
    {
        
    }
}
