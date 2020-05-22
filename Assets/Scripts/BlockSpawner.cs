﻿using System.Collections;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject obstaclePrefab;
    public GameObject collectablePrefab;
    public GameObject rotationTarget;
    private Vector3 relativePos;
    public float spawnRate = 2f;
    float nextSpawn = 0f;

    // Start is called before the first frame update
    void Start()
    {
        relativePos = rotationTarget.transform.position;
    }

    private void FixedUpdate()
    {
        SpawnBlocks();
    }

    void SpawnBlocks()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;

            // Code to execute after the delay
            int randomIndex = Random.Range(0, spawnPoints.Length);

            for (int i = 0; i < spawnPoints.Length; i++)
            {
                if (randomIndex != i)
                {
                    Instantiate(obstaclePrefab, spawnPoints[i].position, Quaternion.LookRotation(relativePos, Vector3.up));
                }
                else {
                    Instantiate(collectablePrefab, spawnPoints[i].position, Quaternion.LookRotation(relativePos, Vector3.up));
                }
            }
        }
    }
}
