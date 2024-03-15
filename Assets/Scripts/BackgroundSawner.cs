using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSpawner : MonoBehaviour
{
    [SerializeField]
    List<GameObject> SoloEnemyList = new List<GameObject>();
    [SerializeField] float minBGSpawnTime;
    [SerializeField] float maxPlanetSpawnTime;
    Vector2 spawnPoint;
    float xSpawn = 10;

    private void Start()
    {
        StartCoroutine(SpawnPlanet());
    }
    IEnumerator SpawnPlanet()
    {
        yield return new WaitForSeconds(2);
        while (PlayerController.instance != null)
        {
            GameObject randomPlanet = SoloEnemyList[Random.Range(0, SoloEnemyList.Count)];
            float timeBetweenSpawn = Random.Range(minEnemySpawnTime, maxEnemySpawnTime);
            Instantiate(randomPlanet,spawnPoint,Quaternion.Euler(new Vector3(0,0,-90)));
            yield return new WaitForSeconds(timeBetweenSpawn);
        }

    }

}
