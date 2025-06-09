using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms.Impl;

public class Create_obj1 : MonoBehaviour
{
    public GameObject cube;
    List<GameObject> cubes = new List<GameObject>();
    List<int> indexes = new List<int>();
    private int x; //������� ������������ �������
    private int y;

    public GameObject sphere;
    RaycastHit hit; //����������� �����, ���� ����� ���������� � �����������
    private Ray ray; //�����������, ���� ����� ����������

    public Camera camera;

    void Start()
    {
        for (float i = 1; i < 7; i++)
        {
            cubes.Add(GameObject.Instantiate(cube, new Vector3(175f, 15.30f, 162.30f - 10 * i), Quaternion.identity));
        }

        for (float i = 0; i < 7; i++)
        {
            cubes.Add(GameObject.Instantiate(cube, new Vector3(175, 30.30f, 162.30f - 10 * i), Quaternion.identity));
        }

        for (float i = 0; i < 7; i++)
        {
            cubes.Add(GameObject.Instantiate(cube, new Vector3(175, 45.30f, 162.30f - 10 * i), Quaternion.identity));
        }
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                Shot();
            }     
        }
    }

    void Shot()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit)) //ray - ���, ������� ������������ � ������ ������ //hit - ������ //���� �� ���� ���� ���-�� �������n��, �� Raycast ������ true
        {
            GameObject bullet = GameObject.Instantiate(sphere, camera.transform.position, Quaternion.identity);

            Vector3 dir = hit.point - camera.transform.position;
            bullet.GetComponent<Rigidbody>().AddForce(dir * 700);
        }
    }
}
