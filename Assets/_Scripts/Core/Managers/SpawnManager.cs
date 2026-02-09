using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] animalPrefabs;

    [SerializeField] private float spawnRangeX = 10;
    [SerializeField] private float spawnPosZ = 20;
    [SerializeField] private float minSpawnInterval = 0.5f;
    [SerializeField] private float maxSpawnInterval = 1.5f;
    [SerializeField] private float startDelay = 2f;

    private Coroutine spawnCoroutine;


    void Start()
    {
        if (minSpawnInterval > maxSpawnInterval)
        {
            float tmp = minSpawnInterval;
            minSpawnInterval = maxSpawnInterval;
            maxSpawnInterval = tmp;
        }
        spawnCoroutine = StartCoroutine(SpawnRandomIntervalRoutine());
    }


    void OnDisable()
    {
        if (spawnCoroutine != null)
            StopCoroutine(spawnCoroutine);
    }


    IEnumerator SpawnRandomIntervalRoutine()
    {
        yield return new WaitForSeconds(startDelay);

        while (true)
        {
            SpawnOnce();

            float wait = Random.Range(minSpawnInterval, maxSpawnInterval);
            yield return new WaitForSeconds(wait);
        }
    }


    void SpawnOnce()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        
        Vector3 spawnPos = new Vector3(
            Random.Range(-spawnRangeX, spawnRangeX), 
            0, 
            spawnPosZ);
        Instantiate(
            animalPrefabs[animalIndex], 
            spawnPos, 
            animalPrefabs[animalIndex].transform.rotation);
    }
}
