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
        GameObject explosion = Instantiate(explosionPrefab,transform.position,Quaternion.identity) ;
        //AudioManager.Instance.PlayScoutSpecial();
        Destroy(explosion,superDuration);
    }
}
