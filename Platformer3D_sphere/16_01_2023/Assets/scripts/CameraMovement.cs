using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private float x_rotation;
    private float y_rotation;
    private Camera player_camera;

    [Range (0.01f, 10f)]
    public float sensetivity = 5f;

    private void Awake()
    {
        player_camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        MouseMove();
    }

    public void MouseMove()
    {
        x_rotation += Input.GetAxis("Mouse X");
        x_rotation = Mathf.Clamp(x_rotation, -90f, 90f);
        y_rotation += Input.GetAxis("Mouse Y");
        y_rotation = Mathf.Clamp(y_rotation, -90f, 90f);

        player_camera.transform.rotation = Quaternion.Euler(-y_rotation, x_rotation, 0);
    }
}
