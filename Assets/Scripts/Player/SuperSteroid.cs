using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class SuperSteroid : Super
{
    [SerializeField] CharacterClass infos;
    float rateOfFire;
    
    public override void StartSuper()
    {
        StartCoroutine(StartSteroid());
    }
    IEnumerator StartSteroid()
    {
        rateOfFire = infos.rateOfFire;
        rateOfFire /= 2.5f;
        controller.rateOfFire = rateOfFire;
        controller.bullet = controller.infos.specialBullet;
        yield return new WaitForSeconds(superDuration);
        rateOfFire = infos.rateOfFire;
        controller.bullet = controller.infos.bullet;
        controller.rateOfFire = rateOfFire;
    }
}
