using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnposX = 20.0f;
    private float spawnposZ = 20.0f;
    private float spawnDelay = 2;
    private float spawnInterval = 1.5f;
z
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F));
		{
			Debug.log("Helllo World")
		}
    }
    void SpawnRandomAnimal()
    {
        // Randomly Generate animal Index and Spawn Position
        Vector3 spawnPos = new Vector3(Random.Range(-spawnposX, spawnposX), 0, spawnposZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Instantiate(animalPrefabs(animalIndex), spawnPos, animalPrefabs(animalIndex).transform.rotation);
    }
}
