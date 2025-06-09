using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace App.Code
{
    [RequireComponent(typeof(Rigidbody), typeof(CapsuleCollider))]    // Атрибут, чтобы с игрока никуда не пропали компоненты Rigidbody и BoxCollider
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float _moveSpeed;
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private FixedJoystick _joystick;
        [SerializeField] private Animator _animator;

        private void FixedUpdate()    // FixedUpdate - потому что действия с физикой
        {
            _rigidbody.velocity = new Vector3(_joystick.Horizontal * _moveSpeed, _rigidbody.velocity.y, _joystick.Vertical * _moveSpeed);

            if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
            {
                transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
            }
            
            var directionVector = new Vector3(_joystick.Horizontal, 0, _joystick.Vertical);
            _animator.SetFloat("Speed", Vector3.ClampMagnitude(directionVector, 1).magnitude);
        }
        
        
    }
}


