using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Animation anim;
    private float speed = 5.0f;
    private float velocity = 0.0f;
    private float gravity = 12.0f;
    private Vector3 move;
    private float duration = 2.0f;
    private CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time < duration)
        {
            controller.Move(Vector3.forward * speed * Time.deltaTime);
            return;
        }
        move = Vector3.zero;

        if (controller.isGrounded)
        {
            velocity = -0.5f;
        }
        else
        {
            velocity -= gravity * Time.deltaTime;
        }


        move.x = Input.GetAxisRaw("Horizontal") * speed;
        move.y = velocity;
        move.z = speed;

        controller.Move(move * Time.deltaTime);
    }
}
