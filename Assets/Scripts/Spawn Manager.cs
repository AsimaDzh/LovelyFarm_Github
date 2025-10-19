using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] animalPrefabs;
    [SerializeField] private float spawnRangeX = 10;
    [SerializeField] private float spawnPosZ = 20;

    [SerializeField] private float startDelay = 2f;
    [SerializeField] float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomInterval", startDelay, spawnInterval);
    }

    void SpawnRandomInterval()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
