using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGenerator : MonoBehaviour
{
    [SerializeField] private SpawnableElements spawnableElements;
    [SerializeField] private UsableMaterials usableMaterials;

    //will hold the spawned walls
    [SerializeField] private List<GameObject> spawnedWalls = new List<GameObject>();
    public List<GameObject> SpawnedWalls => spawnedWalls;

    [SerializeField] private bool isWallWithWindow = false;
    [SerializeField] private bool isWallWithDoor = false;
    private int doorWallPos;
    private int windowWallPos;

    [SerializeField] private Transform[] wallSpawnPoints;

    private void Start()
    {
        //generating the walls
        GenerateWalls();
    }

    private void GenerateWalls()
    {
        int chosenMaterial = Random.Range(0, usableMaterials.WallMaterial.Length);

        //we will choose a random pos for the door wall
        doorWallPos = Random.Range(0, 3);

        //we will find a random pos for the window wall, if the chosen position is the same as the door one we will chose another one
        while(isWallWithWindow==false)
        {
            windowWallPos = Random.Range(0, 3);
            if(windowWallPos!=doorWallPos)
            {
                isWallWithWindow = true;
            }
        }

        for(int i=0;i<wallSpawnPoints.Length;i++)
        {
            //if we are on the chosen position for the doorWall we will spawn the door wall
            if(i==doorWallPos)
            {
                int chosenWall = Random.Range(0, spawnableElements.WallsWithDoor.Length);

                GameObject WallWithDoor = Instantiate(spawnableElements.WallsWithDoor[chosenWall], wallSpawnPoints[i].transform.position, wallSpawnPoints[i].transform.rotation);

                //setting the floor as parent
                WallWithDoor.transform.parent = this.transform;

                //giving our wall the material
                WallWithDoor.GetComponent<MeshRenderer>().material = usableMaterials.WallMaterial[chosenMaterial];

                //adding it to the list
                spawnedWalls.Add(WallWithDoor);
            }
            //if we are on the chosen position for the windowsWall we will spawn a windows wall
            else if (i==windowWallPos) 
            {
                int chosenWall = Random.Range(0, spawnableElements.WallsWithWindow.Length);

                GameObject WallWithWindow= Instantiate(spawnableElements.WallsWithWindow[chosenWall], wallSpawnPoints[i].transform.position, wallSpawnPoints[i].transform.rotation);

                //setting the floor as parent
                WallWithWindow.transform.parent = this.transform;

                //giving our wall the material
                WallWithWindow.GetComponent<MeshRenderer>().material = usableMaterials.WallMaterial[chosenMaterial];

                //adding it to the list
                spawnedWalls.Add(WallWithWindow);
            }
            //else we will spawn a normal wall
            else
            {
                int chosenWall = Random.Range(0, spawnableElements.BasicWalls.Length);

                GameObject BasicWall= Instantiate(spawnableElements.BasicWalls[chosenWall], wallSpawnPoints[i].transform.position, wallSpawnPoints[i].transform.rotation);

                //setting the floor as parent
                BasicWall.transform.parent = this.transform;

                //giving our wall the material
                BasicWall.GetComponent<MeshRenderer>().material = usableMaterials.WallMaterial[chosenMaterial];

                //adding it to the list
                spawnedWalls.Add(BasicWall);
            }
        }
    }
}
