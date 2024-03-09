using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_material : MonoBehaviour
{
    public Material material1;
    public Material material2;

    public GameObject sphere;
    public void OnClick_change_material()
    {
        sphere.GetComponent<MeshRenderer>().material = material2;
    }
}
