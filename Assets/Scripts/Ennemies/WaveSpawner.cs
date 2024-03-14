using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{

    [SerializeField]
    List<GameObject> WaveEnemyList = new List<GameObject>();
    [SerializeField] float minWaveSpawnTime;
    [SerializeField] float maxWaveSpawnTime;
    Vector2 spawnPoint;
    float ySpawn = 10;

    private void Start()
    {
        StartCoroutine(WaveSpawn());
    }

    IEnumerator WaveSpawn()
    {
        yield return new WaitForSeconds(2);
        while (Playercontroller.instance != null)
        {
            GameObject randomEnemy = WaveEnemyList[Random.Range(0, WaveEnemyList.Count)];
            if(randomEnemy == WaveEnemyList[1])
            {
                spawnPoint = new Vector2(ySpawn,0);
            }
            else
            {
                spawnPoint = new Vector2(ySpawn, Random.Range(-4.2f, 4.2f));
            }
            float timeBetweenEnemySpawn = Random.Range(minWaveSpawnTime, maxWaveSpawnTime);
            GameObject.Instantiate(randomEnemy,spawnPoint,Quaternion.Euler(new Vector3(0,0,-90)));
            yield return new WaitForSeconds(timeBetweenEnemySpawn);
        }

    }

}
