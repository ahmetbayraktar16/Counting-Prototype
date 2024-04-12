using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] List<GameObject> fruits;
    float spawnRate = 0.25f;

    void Start()
    {
        InvokeRepeating("SpawnFruits", 1, spawnRate);
    }

    void Update()
    {

    }

    void SpawnFruits()
    {
        int randomIndex = Random.Range(0, fruits.Count);
        float randomX = Random.Range(-5, 5);
        Vector3 spawnPos = new Vector3(randomX, 6, -4.75f);
        Instantiate(fruits[randomIndex], spawnPos, transform.rotation);
    }
}
