using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomGeneratorController : MonoBehaviour
{
    //data
    [SerializeField] private SpawnableElements spawnableElements;

    [Space]

    //will select the time of day
    [SerializeField] private int timeOfDay;
    public int TimeOfDAy => timeOfDay;

    [Space]

    //will hold all the spawned assets for deletion
    [SerializeField] private GameObject assetHolder;

}
