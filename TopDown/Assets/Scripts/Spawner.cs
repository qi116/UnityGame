using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] spawnSpots;

    private float timeBtwSpawn;
    public float startTimeBtw;
    void Start()
    {
        timeBtwSpawn = startTimeBtw; 
    }

    void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            int randPos = Random.Range(0, spawnSpots.Length);
            Instantiate(enemy, spawnSpots[randPos].position, Quaternion.identity);
            timeBtwSpawn = startTimeBtw;
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
