using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorObjectGenerator : MonoBehaviour
{
    [SerializeField] private SpawnableElements spawnableElements;
    [SerializeField] private UsableMaterials usableMaterials;

    //will hold the spawned floor objects
    [SerializeField] private List<GameObject> spawnedFloorObjects = new List<GameObject>();
    public List<GameObject> SpawnedFloorObjects => spawnedFloorObjects;

    private void Start()
    {
        SpawnTable();
    }

    private void SpawnTable()
    {
        int chosenTable = Random.Range(0, spawnableElements.Tables.Length);

        int chosenMaterial = Random.Range(0, usableMaterials.ChairMaterial.Length);

        //we will spawn the table in the middle of the room but its rotation on the y axis will be random
        GameObject table = Instantiate(spawnableElements.Tables[chosenTable], new Vector3(0f, 0f, 0f), Quaternion.Euler(-90, Random.Range(0,360), 0));

        //setting the floor as parent
        table.transform.parent = this.transform;

        //giving our spawned table a random material
        table.GetComponent<MeshRenderer>().material = usableMaterials.TableMaterial[chosenMaterial];

        //adding it to the list
        spawnedFloorObjects.Add(table);
    }
}
