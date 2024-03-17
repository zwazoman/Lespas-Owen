using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SuperExplosion : Super
{
    [SerializeField] GameObject explosionPrefab;
    public override void StartSuper()
    {
        Explosion();
    }
    void Explosion()
    {
        GameObject explosion = Instantiate(explosionPrefab,transform/*.position,Quaternion.identity*/) ;
        AudioManager.Instance.PlaySFX(AudioManager.Instance.scoutSpecialSound);
        Destroy(explosion,superDuration);
    }
}
