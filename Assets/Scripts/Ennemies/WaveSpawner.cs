using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    [SerializeField] GameObject enemySpawner;
    [SerializeField]
    List<GameObject> waveEnemyList = new List<GameObject>();
    [SerializeField] float minWaveSpawnTime;
    [SerializeField] float maxWaveSpawnTime;
    [SerializeField] float firstWaveSpawnTime;

    Vector2 spawnPoint;
    float ySpawn = 0;

    private void Start()
    {
        StartCoroutine(WaveSpawn());
    }

    IEnumerator WaveSpawn()
    {
        yield return new WaitForSeconds(firstWaveSpawnTime);
        while (Playercontroller.instance != null)
        {
            enemySpawner.SetActive(false);
            int randomIndex = Random.Range(0, waveEnemyList.Count);
            GameObject randomEnemy = waveEnemyList[randomIndex];
            switch (randomIndex)
            {
                case 1:
                    spawnPoint = new Vector2(9.2f,ySpawn);
                    break;
                default:
                    spawnPoint = new Vector2(10, ySpawn);
                    break;
            }
            float timeBetweenEnemySpawn = Random.Range(minWaveSpawnTime, maxWaveSpawnTime);
            GameObject.Instantiate(randomEnemy,spawnPoint,Quaternion.identity);
            enemySpawner.SetActive(true);
            yield return new WaitForSeconds(timeBetweenEnemySpawn);
        }

    }

}
