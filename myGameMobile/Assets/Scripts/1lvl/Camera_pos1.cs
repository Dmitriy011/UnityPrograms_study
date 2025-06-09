using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Camera_pos1 : MonoBehaviour
{
    public GameObject camera;

    public void OnClick_camera_pos1()
    {
        camera.transform.position = new Vector3(40.5f, 100.80f, 187.69f);
        camera.transform.rotation = new Quaternion(0.13f, 0.84f, -0.08f, 0.51f);
    }
}
