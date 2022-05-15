using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairGenerator : MonoBehaviour
{
    [SerializeField] private SpawnableElements spawnableElements;

    //will hold the spawned floor objects
    [SerializeField] private List<GameObject> spawnedChairs = new List<GameObject>();
    public List<GameObject> SpawnedChairs => spawnedChairs;

    [SerializeField] private Transform[] chairSpawnPoints;

    private void Start()
    {
        GenerateChairs();
    }

    private void GenerateChairs()
    {
        int chosenChair = Random.Range(0, spawnableElements.Chairs.Length);

        //geting random position for the first required chair
        int chair1Pos = Random.Range(0, chairSpawnPoints.Length);

        //getting random pos for the second required chair, but making sure it is not the same as the first
        int chair2Pos = 0;
        bool chair2PosFound = false;
        while(chair2PosFound==false)
        {
            chair2Pos = Random.Range(0, chairSpawnPoints.Length);
            if(chair2Pos!=chair1Pos)
            {
                chair2PosFound = true;
            }
        }

        //spawning the chairs
        for(int i=0;i<chairSpawnPoints.Length;i++)
        {
            //if we are on one of the chosen positions for the required chairs we will spawn them
            if (i == chair1Pos || i == chair2Pos)
            {
                GameObject spawnedChair = Instantiate(spawnableElements.Chairs[chosenChair], chairSpawnPoints[i].position, chairSpawnPoints[i].rotation);

                //setting the table as parent
                spawnedChair.transform.parent = this.transform;

                //adding it to the list
                spawnedChairs.Add(spawnedChair);
            }
            //else we will raandomly decide if we spawn another chair
            else
            {
                int willSpawnChair = Random.Range(0, 2);

                if (willSpawnChair == 0)
                {
                    GameObject spawnedChair = Instantiate(spawnableElements.Chairs[chosenChair], chairSpawnPoints[i].position, chairSpawnPoints[i].rotation);

                    //setting the table as parent
                    spawnedChair.transform.parent = this.transform;

                    //adding it to the list
                    spawnedChairs.Add(spawnedChair);
                }
            }
        }
    }
}
