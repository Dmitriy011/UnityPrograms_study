using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_pos3 : MonoBehaviour
{
    public GameObject camera;
    public void OnClick_camera_pos3()
    {
        camera.transform.position = new Vector3(65.65f, 86.09f, 18.92f);
        camera.transform.rotation = new Quaternion(0.16f, 0.39f, -0.17f, 0.88f);
    }
}
