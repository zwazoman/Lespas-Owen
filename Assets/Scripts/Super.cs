using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Super : MonoBehaviour
{
    [SerializeField] protected PlayerController controller;
    [SerializeField] protected float superDuration;

    public virtual void StartSuper()
    {

    }
}
