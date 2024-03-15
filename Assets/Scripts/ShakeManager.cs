using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ShakeManager : MonoBehaviour
{

    public static ShakeManager instance;

    [SerializeField] private float globalShakeForce = 1;

    private void Awake()
    {
        if(instance == null) 
        {
            instance = this;
        }
    }

    public void CameraShake(CinemachineImpulseSource impulseSource)
    {
        impulseSource.GenerateImpulseWithForce(globalShakeForce);
    }
}
