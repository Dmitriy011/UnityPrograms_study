using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_player : MonoBehaviour
{
    public Transform target;
    public Transform old;
    public Transform cam;

    public float speed;
    public float turn_speed;
    private float x_rotation;
    private float y_rotation;

    public LayerMask obstacle_mask; //���������, �� ������� ������ �������� 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate() //��� ������
    {
        transform.position = Vector3.Lerp(transform.position, target.position, speed * Time.deltaTime); //������� �������� �� �������
        x_rotation += Input.GetAxis("Mouse X") * turn_speed;
        y_rotation += Input.GetAxis("Mouse Y") * turn_speed;

        //������� � Unity � �������  Quaternion
        transform.rotation = Quaternion.Euler(y_rotation, x_rotation, 0f);

        //���������, ��� ������ ����� �� ������
        RaycastHit hit;
        if (Physics.Raycast(target.position, old.position - target.position, out hit, Vector3.Distance(old.position, target.position), obstacle_mask))
        {
            // ����� ����� �����������, �� ����� � ���������
            cam.position = hit.point; //���� � ���-�� �����������, �� ������������ � �����, ������� ����������� hit.point
        }
        else 
        {
            cam.position = old.position;
        }
    }
}
