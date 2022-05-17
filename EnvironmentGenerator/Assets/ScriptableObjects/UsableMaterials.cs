using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UsableMaterials", menuName = "ScriptableObjects/UsableMaterials")]

public class UsableMaterials : ScriptableObject
{
    [Header("Wall Materials")]
    [Space]
    //will hold wall materials
    [SerializeField] private Material[] wallMaterial;
    public Material[] WallMaterial => wallMaterial;

    [Header("Floor Materials")]
    [Space]
    //will hold wall materials
    [SerializeField] private Material[] floorMaterial;
    public Material[] FloorMaterial => floorMaterial;

    [Header("Table Materials")]
    [Space]
    //will hold wall materials
    [SerializeField] private Material[] tableMaterial;
    public Material[] TableMaterial => tableMaterial;

    [Header("Chair Materials")]
    [Space]
    //will hold wall materials
    [SerializeField] private Material[] chairMaterial;
    public Material[] ChairMaterial => chairMaterial;

    [Header("Mug Materials")]
    [Space]
    //will hold wall materials
    [SerializeField] private Material[] mugMaterial;
    public Material[] MugMaterial => mugMaterial;

    [Header("Plate Materials")]
    [Space]
    //will hold wall materials
    [SerializeField] private Material[] plateMaterial;
    public Material[] PlateMaterial => plateMaterial;
}
