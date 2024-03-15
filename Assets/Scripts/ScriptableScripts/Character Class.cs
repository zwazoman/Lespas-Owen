using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "Characters")]
public class CharacterClass : ScriptableObject
{
    [field: SerializeField]
    public float speed { get; private set; }

    [field: SerializeField]
    public float rateOfFire { get; private set; }

    [field: SerializeField]
    public int hp { get; private set; }

    [field: SerializeField]
    public float cooldown { get; private set; }

    [field: SerializeField]
    public GameObject bullet { get; private set; }

    [field: SerializeField]
    public bool assault { get; private set; }

    [field: SerializeField]
    public bool rush { get; private set; }

    [field: SerializeField]
    public bool scout { get; private set; }

    [field: SerializeField]
    public float recoil { get; private set; }

    [field: SerializeField]
    public GameObject specialBullet { get; private set; }
}

