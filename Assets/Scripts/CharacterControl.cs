using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public float moveSpeed;
    //public Rigidbody rigidB;
    public float jumpForce;
    public CharacterControl controller;
    private Vector3 moveDirection;
    public float gravityScale;

    // Start is called before the first frame update
    void Start()
    {
        //rigidB = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterControl>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = new Vector3(Input.GetAxis("Horizontal") * moveSpeed,
            moveDirection.y, Input.GetAxis("Vertical") * moveSpeed);

        if (Input.GetButtonDown("Jump"))
        {
            moveDirection.y = jumpForce;
        }
        moveDirection.y = moveDirection.y * (Physics.gravity.y * gravityScale 
            * Time.deltatime);
        controller.Move(moveDirection * Time.deltaTime);










        /*
        rigidB.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed,
            rigidB.velocity.y, Input.GetAxis("Vertical") * moveSpeed);

        if (Input.GetButtonDown("Jump"))
        {
            rigidB.velocity = new Vector3(rigidB.velocity.x,
                jumpForce, rigidB.velocity.z);
        }
        */
    }
}
