using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    private GameObject Ammo;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Tire");
            Instantiate(Ammo, new Vector2, Quaternion.identity);
        }
    }
}
