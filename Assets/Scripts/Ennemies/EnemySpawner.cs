using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    List<GameObject> SoloEnemyList = new List<GameObject>();
    [SerializeField]
    List<GameObject> WaveEnemyList = new List<GameObject>();
    [SerializeField] float minEnemySpawnTime;
    [SerializeField] float maxEnemySpawnTime;
    [SerializeField] float minWaveSpawnTimen;
    [SerializeField] float maxWaveSpawnTimen;
    Vector2 spawnPoint;
    float xSpawn = 10;

    private void Start()
    {
        StartCoroutine(EnemySpawn());
    }

    private void OnEnable()
    {
        StartCoroutine(EnemySpawn());
    }


    IEnumerator EnemySpawn()
    {
        yield return new WaitForSeconds(2);
        while (PlayerController.instance != null)
        {
            GameObject randomEnemy = SoloEnemyList[Random.Range(0, SoloEnemyList.Count)];
            if(randomEnemy == SoloEnemyList[1])
            {
                spawnPoint = new Vector2(9.2f,0);
            }
            else
            {
                spawnPoint = new Vector2(xSpawn, Random.Range(-4.2f, 4.2f));
            }
            float timeBetweenEnemySpawn = Random.Range(minEnemySpawnTime, maxEnemySpawnTime);
            GameObject.Instantiate(randomEnemy,spawnPoint,Quaternion.Euler(new Vector3(0,0,-90)));
            yield return new WaitForSeconds(timeBetweenEnemySpawn);
        }

    }

}
