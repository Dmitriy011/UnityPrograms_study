using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] private float speed_move;
    [SerializeField] private float jump_force;

    private float gravity_force;
    private  Vector3 player_dir;

    [SerializeField] private Animator animator;
    [SerializeField] private CharacterController character_controller;


    // Start is called before the first frame update
    void Start()
    {
        //получаем ссылки
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
        }

        player_dir.y = gravity_force;
        player_dir = transform.TransformDirection(player_dir);
        character_controller.Move(player_dir * Time.deltaTime * speed_move);
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
