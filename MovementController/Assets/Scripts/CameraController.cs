using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace App.Code
{
    public class CameraController : MonoBehaviour
    {
        public Transform playerTransform;
        public Vector3 offset; // offset, на который будем ставит ькамеру, чтобы была чуть выше персонажа и сзади
        public float cameraPosSpeed = 5.0f;

        private void FixedUpdate()
        {
            Vector3 newCameraPos = new Vector3(playerTransform.position.x + offset.x, playerTransform.position.y + offset.y, playerTransform.position.z + offset.z);
            transform.position = Vector3.Lerp(transform.position, newCameraPos, cameraPosSpeed * Time.deltaTime);
        }
    }
}
