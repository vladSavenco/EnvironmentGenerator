using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRandomizer : MonoBehaviour
{
    //a list to keep track of the cam pos
    [SerializeField] private List<Transform> cameraPos;

    //for the cam pos
    private float x;
    private float y;
    private float z;

    public void RandomizeCamera(int n,int m)
    {
        RandomizeCamPos();

        //we want the camera to be towards the outskirts of the room so it can see as much as possible
        if (x >= -3 && x <= 3 || z >= -3 && z <= 3)
        {
            RandomizeCamPos();
        }

        this.transform.position = new Vector3(x, y, z);

        //the camera will look towards the middle of the room
        this.transform.LookAt(new Vector3(0, 2f, 0));

        ScreenshotHandler.TakeScreenshot_Static(Screen.width, Screen.height, n, m);

        Debug.Log("camera randomized");
    }

    //we randomize the cam pos
    public void RandomizeCamPos()
    {
         x = Random.Range(-7, 7);
         y = Random.Range(2, 5);
         z = Random.Range(-7, 7);
    }
}
