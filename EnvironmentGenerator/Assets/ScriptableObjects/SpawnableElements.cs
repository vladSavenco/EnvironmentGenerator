using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpawnableElements", menuName = "ScriptableObjects/SpawnableElements")]

public class SpawnableElements : ScriptableObject
{
    [Header("Basic Room Elements")]
    [Space]
    //will hold basic walls prefabs
    [SerializeField] private GameObject[] basicWalls;
    public GameObject[] BasicWalls => basicWalls;
    [Space]
    //will hold walls with windows prefabs
    [SerializeField] private GameObject[] wallsWithWindow;
    public GameObject[] WallsWithWindow => wallsWithWindow;
    [Space]
    //will hold walls with doors prefabs
    [SerializeField] private GameObject[] wallsWithDoor;
    public GameObject[] WallsWithDoor => wallsWithDoor;
    [Space]
    //will hold floor prefabs .... are there more than one? (past vlad) .... NO! (future vlad) 
    [SerializeField] private GameObject[] floors;
    public GameObject[] Floors => floors;

    [Space]

    [Header("Things On The Floor")]
    [Space]
    //will hold tables prefabs
    [SerializeField] private GameObject[] tables;
    public GameObject[] Tables => tables;
    [Space]
    //will hold chair prefabs
    [SerializeField] private GameObject[] chairs;
    public GameObject[] Chairs => chairs;
    [Space]
    //will hold sofa/ armchair prefabs
    [SerializeField] private GameObject[] sofas;
    public GameObject[] Sofas => sofas;
    [Space]
    //will hold bookshelf/ cabinets prefabs
    [SerializeField] private GameObject[] bookshelfs;
    public GameObject[] Bookshelfs => bookshelfs;
    [Space]
    //will hold floor lamp prefabs
    [SerializeField] private GameObject[] floorLamps;
    public GameObject[] FloorLamps => floorLamps;

    [Space]

    [Header("Things On The Walls")]
    [Space]
    //will hold painting/ television prefabs
    [SerializeField] private GameObject[] paintings;
    public GameObject[] Paintings => paintings;
    [Space]
    //will hold wall lamp prefabs
    [SerializeField] private GameObject[] wallLamps;
    public GameObject[] WallLamps => wallLamps;

    [Space]

    [Header("Table Objects")]
    [Space]
    //will hold mug prefabs ... remember at least one
    [SerializeField] private GameObject[] mugs;
    public GameObject[] Mugs => mugs;
    [Space]
    //will hold plant prefabs ... remember at least one
    [SerializeField] private GameObject[] plants;
    public GameObject[] Plants => plants;
    [Space]
    //will hold plate prefabs
    [SerializeField] private GameObject[] plates;
    public GameObject[] Plates => plates;

    [Space]

    [Header("BookShelf/Cabinet Objects")]
    [Space]
    //will hold book prefabs
    [SerializeField] private GameObject[] books;
    public GameObject[] Books => books;
    [Space]
    //will hold mug prefabs ... remember at least one
    [SerializeField] private GameObject[] others;
    public GameObject[] Others => others;
}
