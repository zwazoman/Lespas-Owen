using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Attack : MonoBehaviour
{
    internal GameObject bullet;
    internal float rateOfFire;
    public abstract void Shoot();


}
