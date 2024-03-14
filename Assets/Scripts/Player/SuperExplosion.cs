using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class SuperExplosion : Super
{
    [SerializeField] GameObject explosionPrefab;
    public override void StartSuper()
    {
        Explosion();
    }
    void Explosion()
    {
        print("CONNARD DE NOAH");
        GameObject explosion = Instantiate(explosionPrefab,transform.position,Quaternion.identity) ;
        Destroy(explosion,superDuration);
    }
}
