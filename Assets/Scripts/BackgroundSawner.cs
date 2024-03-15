using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSpawner : MonoBehaviour
{
    [SerializeField]
    List<GameObject> SoloEnemyList = new List<GameObject>();
    [SerializeField] float minBGSpawnTime;
    [SerializeField] float maxBGSpawnTime;
    Vector2 spawnPoint;
    float xSpawn = 10;

    private void Start()
    {
        StartCoroutine(SpawnBG());
    }
    IEnumerator SpawnBG()
    {
        yield return new WaitForSeconds(2);
        while (PlayerController.instance != null)
        {
            GameObject randomBG = SoloEnemyList[Random.Range(0, SoloEnemyList.Count)];
            float timeBetweenSpawn = Random.Range(minBGSpawnTime, maxBGSpawnTime);
            Instantiate(randomBG,spawnPoint,Quaternion.Euler(new Vector3(0,0,-90)));
            yield return new WaitForSeconds(timeBetweenSpawn);
        }

    }

}
