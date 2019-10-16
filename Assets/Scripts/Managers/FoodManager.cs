﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour
{
    public GameObject prefab;
    public float spawnDelay = 1f;
    public int startFoodAvailable = 200;
    public int maxFoodAvailable = 500;

    private float spawnTimer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < startFoodAvailable; i++)
            Spawn();
    }
    public void Spawn()
    {
        Vector3 randomPos = Game.Instance.GetRandomPosition();
        Instantiate(prefab, randomPos, Quaternion.identity, transform);
    }
    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        // If timer reaches delay
        if (spawnTimer >= spawnDelay)
        {
            // Spawn a new Food
            Spawn();
            // Reset Timer
            spawnTimer = 0f;
        }
    }
}
