using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class SuperSteroid : MonoBehaviour
{
    [SerializeField] 
    public void StartSteroid()
    {
        StartCoroutine(StartSuper());
    }
    IEnumerator StartSuper()
    {
        rateOfFire /= 2;
        yield return new WaitForSeconds(5);
        rateOfFire = infos.rateOfFire;
    }
}
