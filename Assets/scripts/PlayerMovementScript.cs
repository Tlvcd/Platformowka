using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public CharacterController controller;
    public GameObject hitboxrig;
    public float speed = 12f;
    public float gravity = -18f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    Vector3 velocity;
    public float jumpHeight = 1f;
    public int doublejump = 1;
    public bool isGrounded;
    public bool doublejumpenabled;
    public int jumpsubtract=1;
    public int bhoptime;
    public bool bhopenabled;
    public void bhopen(bool togbhop)
    {
        if (togbhop == true){
            bhopenabled = true;
        } else
        {
            bhopenabled = false;
        }
    }
    public void infjump(bool togjump)
    {
        if (togjump == true)
        {
            jumpsubtract = 0;
        }
        else
        {
            jumpsubtract = 1;
        }
    }
    public void djump(bool togdj)
    {
        if (togdj == true)
        {
            doublejumpenabled = true;
        }
        else
        {
            doublejumpenabled = false;
        }
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move*speed*Time.deltaTime);
        hitboxrig.transform.position = controller.transform.position;
        if (Input.GetButtonDown("Jump")&& isGrounded)
        {
            bhoptime = 0;
            if (bhopenabled == true)
            {
                speed += 2;
            }
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            
        } else if(Input.GetButtonDown("Jump")&&(doublejumpenabled && doublejump>0)){
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            doublejump = doublejump - jumpsubtract;
            speed = speed+2;
        }
        if (isGrounded)
        {
            
            doublejump = 1;
            bhoptime += 1;
            if (bhoptime == 50)
            {
                speed = 8;
            }
            
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    } 
}
