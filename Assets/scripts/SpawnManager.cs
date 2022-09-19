using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    float topSpawnX = 32, topSpawnZ = 20;
    float sideSpawnX = 40, sideSpawnMaxZ = 16, sideSpawnMinZ = 0;
    float spawnDelay = 2, spawnIntervel = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimalsTop", spawnDelay, spawnIntervel);

        //bonus feature challenge
        InvokeRepeating("SpawnAnimalsLeft", spawnDelay, spawnIntervel+1);
        InvokeRepeating("SpawnAnimalsRight", spawnDelay, spawnIntervel+1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnAnimalsTop()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-topSpawnX, topSpawnX), 0, topSpawnZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    // Bonus feature challenge
    void SpawnAnimalsLeft()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        Vector3 spawnRot = new Vector3(0, 90, 0);

        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(spawnRot));
    }
    void SpawnAnimalsRight()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        Vector3 spawnRot = new Vector3(0, -90, 0);

        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(spawnRot));
    }
}
