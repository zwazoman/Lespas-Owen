using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class SuperSteroid : MonoBehaviour
{
    [SerializeField] PlayerController controller;
    [SerializeField] CharacterClass infos;
    float rateOfFire;
    
    public void StartSteroid()
    {
        StartCoroutine(StartSuper());
    }
    IEnumerator StartSuper()
    {
        rateOfFire = infos.rateOfFire;
        rateOfFire /= 2.5f;
        controller.rateOfFire = rateOfFire;
        controller.bullet = controller.infos.specialBullet;
        yield return new WaitForSeconds(3);
        rateOfFire = infos.rateOfFire;
        controller.bullet = controller.infos.bullet;
        controller.rateOfFire = rateOfFire;
    }
}
