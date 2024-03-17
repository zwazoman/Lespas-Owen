using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSpawner : MonoBehaviour
{
    [SerializeField]
    List<GameObject> BGList = new List<GameObject>();
    [SerializeField] float minBGSpawnTime;
    [SerializeField] float maxBGSpawnTime;
    [SerializeField] float xSpawn = 10;
    GameObject lastSpawnedObject;

    private void Start()
    {
        StartCoroutine(SpawnBG());
    }
    IEnumerator SpawnBG()
    {
        yield return new WaitForSeconds(2);
        while (PlayerController.instance != null)
        {
            Vector2 spawnPoint = new Vector2 (xSpawn, Random.Range(-4.2f, 4.2f));
            GameObject randomBG = BGList[Random.Range(0, BGList.Count)];
            float timeBetweenSpawn = Random.Range(minBGSpawnTime, maxBGSpawnTime);
            if (randomBG == lastSpawnedObject)
            {
                continue;
            }
            lastSpawnedObject = randomBG;
            GameObject BGObject = Instantiate(randomBG,spawnPoint,Quaternion.identity);
            BGObject.transform.localScale *= Random.Range(1.2f,1.8f);
            yield return new WaitForSeconds(timeBetweenSpawn);
        }

    }

}
