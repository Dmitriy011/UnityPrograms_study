using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>(); //получаем ссылку на Rigidbody из объекта
        rigidbody.velocity = new Vector3 (40f, 40f, 40f);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bottom_wall"))
        {
            rigidbody.velocity = new Vector3(Random.value * 100f, Random.value * 100f, Random.value * 100f);
        }
    }
}
