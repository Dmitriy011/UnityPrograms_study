using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float Speed = 10f;
    public float JumpForce = 300f;
    private bool isGround = false;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start() //����������, ����� ����������� ����
    {
        rb = GetComponent<Rigidbody>(); //���������� � Rigidbody, ������� ����� �� ����� �������
    }

    /*// Update is called once per frame
    void Update() //���������� ������ ���� ����
    {
        
    }*/

    void FixedUpdate() //������ ������������ �� ������
    {
        MovementLogic(); //������ ��������
        JumpLogic();

    }

    private void MovementLogic()
    {
        float move_horizontal = Input.GetAxis("Horizontal");
        float move_vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(move_horizontal, 0.0f, move_vertical);

        rb.AddForce(Speed * movement); //���������� ����
    }

    private void JumpLogic()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            if (isGround == true)
            {
                rb.AddForce(Vector3.up * JumpForce); //Vector3.up - ��� ����, ����� ����� �
            }
        }
    }

    //����� �������� � ���� ������� ������� - ��������� �������� (����������� ��������� � Rigidbody).  ���� ��� ���������� - ������������� ���� ����� IsGroundUpdate
    private void OnCollisionEnter(Collision _collision) 
    {
        IsGroundUpdate(_collision, true);
    }
    private void OnCollisionExit(Collision _collision)
    {
        IsGroundUpdate(_collision, false);
    }

    void IsGroundUpdate(Collision _collision, bool value)
    {
        if(_collision.gameObject.tag == "Ground")
        {
            isGround = value;
        }
    }


}
