using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] private float speed_move = 10;
    [SerializeField] private float jump_force;

    private float gravity_force;
    private Vector3 player_dir;

    private CharacterController character_controller;
    private Animator animator;

    void Start()
    {
        character_controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
        GameGravity();
    }

    void Walk()
    {
        if (character_controller.isGrounded)
        {
            player_dir = Vector3.zero;
            player_dir.x = Input.GetAxis("Horizontal");
            player_dir.z = Input.GetAxis("Vertical");

            if (player_dir.x != 0f || player_dir.z != 0f)
            {
                animator.SetBool("Move", true);
            }
            else
            {
                animator.SetBool("Move", false);
            }

            if (Vector3.Angle(Vector3.forward, player_dir) > 1f || Vector3.Angle(Vector3.forward, player_dir) == 0f)
            {
                Vector3 dir = Vector3.RotateTowards(transform.forward, player_dir, speed_move, 0f);
                transform.rotation = Quaternion.LookRotation(dir);
            }
        }

        player_dir.y = gravity_force;
        character_controller.Move(player_dir * Time.deltaTime);
    }

    void GameGravity()
    {
        if (!character_controller.isGrounded)
        {
            gravity_force -= 10f * Time.deltaTime;
        }
        else
        {
            gravity_force = -1f;
        }
    }
}
