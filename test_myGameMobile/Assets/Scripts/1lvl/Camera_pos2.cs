using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_pos2 : MonoBehaviour
{
    public GameObject camera;
    public void OnClick_camera_pos2()
    {
        camera.transform.position = new Vector3(65.69f, 86.09f, 115.69f);
        camera.transform.rotation = new Quaternion(0.15f, 0.68f, -0.15f, 0.68f);
    }
}
