using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGenerator : MonoBehaviour
{
    [SerializeField] private SpawnableElements spawnableElements;

    //will hold the spawned walls
    [SerializeField] private GameObject[] spawnedWalls;
    public GameObject[] SpawnedWalls => spawnedWalls;

    [SerializeField] private bool isWallWithWindow = false;
    [SerializeField] private bool isWallWithDoor = false;

    [SerializeField] private Transform[] wallSpawnPoints;
}
