using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomGeneratorController : MonoBehaviour
{
    //data
    [SerializeField] private SpawnableElements spawnableElements;

    [Space]

    //will select the time of day
    [SerializeField] private int timeOfDay;
    public int TimeOfDAy => timeOfDay;

    [Space]
    //will deal with the camera
    [SerializeField] private GameObject cam;
    private int nrOfPics = 0;
    private int neededPics = 0;

    public int nrOfRooms = 0;
    public int neededRooms = 0;

    private int totalNrOfGeneratedImmages = 0;

    [Space]

    //will hold all the spawned assets for deletion
    [SerializeField] private GameObject assetHolder=null;

    //timer stuff
    private float timer = 1;
    private float timeout = 1;

    public Text text;

    private void Start()
    {
        SpawnFloor();
    }

    private void SpawnFloor()
    {
        //create folder with the room number as name
        System.IO.Directory.CreateDirectory(Application.dataPath + "/Room"+nrOfRooms);

        assetHolder = Instantiate(spawnableElements.Floors[0], this.transform.position, Quaternion.Euler(-90, 0, 0));

        cam.SetActive(true);

        neededPics = 50;
    }

    private void Timer()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = timeout;

            if (nrOfPics < neededPics)
            {
                cam.GetComponent<CameraRandomizer>().RandomizeCamera(nrOfPics, nrOfRooms);
                nrOfPics++;
                totalNrOfGeneratedImmages++;
            }
            else if(nrOfPics==neededPics)
            {
                neededPics = 0;
                nrOfPics = 0;

                Debug.Log("Room Done!");

                nrOfRooms++;

                if (nrOfRooms <= neededRooms)
                {
                    Destroy(assetHolder);
                    SpawnFloor();
                }
                else
                {
                    Application.Quit();
                }
            }
        }
    }

    private void Update()
    {
        Timer();

        text.text = "Total Number Of Generated Immages : " + totalNrOfGeneratedImmages.ToString();
    }
}
