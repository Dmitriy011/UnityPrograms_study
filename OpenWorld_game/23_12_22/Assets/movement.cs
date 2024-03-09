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
    void Start() //вызываетс€, когда запускаетс€ игра
    {
        rb = GetComponent<Rigidbody>(); //обращаемс€ к Rigidbody, который висит на нашем объекте
    }

    /*// Update is called once per frame
    void Update() //вызываетс€ каждый кадр игры
    {
        
    }*/

    void FixedUpdate() //больше ориентирован на физику
    {
        MovementLogic(); //логика движени€
        JumpLogic();

    }

    private void MovementLogic()
    {
        float move_horizontal = Input.GetAxis("Horizontal");
        float move_vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(move_horizontal, 0.0f, move_vertical);

        rb.AddForce(Speed * movement); //приложение силы
    }

    private void JumpLogic()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            if (isGround == true)
            {
                rb.AddForce(Vector3.up * JumpForce); //Vector3.up - все нули, кроме коорд у
            }
        }
    }

    //когда попадает в поле другого объекта - возникает коллизи€ (пересечение колайдера и Rigidbody).  ≈сли это происходит - разрабатываем спец метод IsGroundUpdate
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
