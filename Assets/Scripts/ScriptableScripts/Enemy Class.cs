using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "Enemies")]
public class EnemyClass : ScriptableObject
{
    [field: SerializeField]
    public float speed { get; private set; }

    [field: SerializeField]
    public int hp { get; private set; }

    [field: SerializeField]
    public GameObject bullet { get; private set; }
}
