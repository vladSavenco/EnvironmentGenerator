using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableObjectGenerator : MonoBehaviour
{
    [SerializeField] private SpawnableElements spawnableElements;
    [SerializeField] private UsableMaterials usableMaterials;

    //will hold the spawned floor objects
    [SerializeField] private List<GameObject> spawnedTableObjects = new List<GameObject>();
    public List<GameObject> SpawnedTableObjects => spawnedTableObjects;


    [SerializeField] private Transform[] plateSpawnPoints;
    [SerializeField] private Transform[] cupSpawnPoints;
    [SerializeField] private Transform[] plantSpawnPoints;

    private void Start()
    {
        GeneratePlates();
        GenerateCup();
        GeneratePlant();
    }

    private void GeneratePlates()
    {
        int chosenPlate = Random.Range(0, spawnableElements.Plates.Length);
        int chosenMaterial = Random.Range(0, usableMaterials.PlateMaterial.Length);

        for (int i=0;i<plateSpawnPoints.Length;i++)
        {
            int willGeneratePlate = Random.Range(0, 2);

            if(willGeneratePlate==0)
            {
                GameObject spawnedPlate = Instantiate(spawnableElements.Plates[chosenPlate], plateSpawnPoints[i].position, plateSpawnPoints[i].rotation);

                //setting the table as parent
                spawnedPlate.transform.parent = this.transform;

                //giving our plate the chosen material
                spawnedPlate.GetComponent<MeshRenderer>().material = usableMaterials.PlateMaterial[chosenMaterial];

                //adding the plate to the list
                spawnedTableObjects.Add(spawnedPlate);
            }
        }
    }
    private void GeneratePlant()
    {
        int chosenPoint = Random.Range(0, plantSpawnPoints.Length);

        GameObject spawnedPlant = Instantiate(spawnableElements.Plants[0], plantSpawnPoints[chosenPoint].position, Quaternion.Euler(plantSpawnPoints[chosenPoint].rotation.x, Random.Range(0, 360), plantSpawnPoints[chosenPoint].rotation.z));

        //setting the table as parent
        spawnedPlant.transform.parent = this.transform;

        //addinf the plant to the list
        spawnedTableObjects.Add(spawnedPlant);
    }
    private void GenerateCup()
    {
        int chosenPoint = Random.Range(0, cupSpawnPoints.Length);
        int chosenMaterial = Random.Range(0, usableMaterials.MugMaterial.Length);

        GameObject spawnedCup = Instantiate(spawnableElements.Mugs[0], cupSpawnPoints[chosenPoint].position, Quaternion.Euler(-90, Random.Range(0, 360), cupSpawnPoints[chosenPoint].rotation.z));

        //setting the table as parent
        spawnedCup.transform.parent = this.transform;

        //giving our mug the chosen material
        spawnedCup.GetComponent<MeshRenderer>().material = usableMaterials.MugMaterial[chosenMaterial];

        //addinf the plant to the list
        spawnedTableObjects.Add(spawnedCup);
    }
}
