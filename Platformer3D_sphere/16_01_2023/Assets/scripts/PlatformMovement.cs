using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    [Range(10f, 100f)]
    public float speed = 20f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime);
        transform.Translate(speed * Vector3.up * Input.GetAxis("Vertical") * Time.deltaTime);

        //transform.position = new Vector3 (Mathf.Clamp(transform.position.x, -31.1f, 30.5f), Mathf.Clamp(transform.position.y, 22.3f, -5.2f), transform.position.z);
    }
}
