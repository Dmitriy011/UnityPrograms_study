using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_mouse : MonoBehaviour
{
    private float x_rotation;
    private float y_rotation;

    [SerializeField] private Camera player_camera;
    [SerializeField] private GameObject player_obj;

    [Range(0.01f, 10f)]
    public float sensivity = 5f;
    void Update()
    {
        MoveMouse();


    }

    void MoveMouse()
    {
        x_rotation += Input.GetAxis("Mouse X");
        y_rotation += Input.GetAxis("Mouse Y");

        y_rotation = Mathf.Clamp(y_rotation, -50f, 50f);

        player_camera.transform.rotation = Quaternion.Euler(-y_rotation, x_rotation, 0f); //поворот камеры

        player_obj.transform.rotation = Quaternion.Euler(0f, x_rotation, 0f);
    }
}
