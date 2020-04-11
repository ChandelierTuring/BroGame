using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControllor : MonoBehaviour
{
    public float moveSpeed;
    private float littleForce = 0.5f;
    private float bruteForce = 1;
    private Vector3 moveForward = Vector3.zero;
    private Rigidbody rig;

    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            moveForward.z += 0.5f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveForward.z += -0.5f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveForward.x += -0.5f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveForward.x += 0.5f;
        }

        GetComponent<Rigidbody>().MovePosition(Quaternion.LookRotation(transform.forward) * moveForward * moveSpeed * Time.fixedDeltaTime + transform.position);
        //rig.AddForce(moveForward, ForceMode.Impulse);

        //CharacterController controller = GetComponent<CharacterController>();
        //if (controller.isGrounded)
        //{
        //    moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //    moveDirection = transform.TransformDirection(moveDirection);
        //    moveDirection *= speed;
        //    //if (Input.GetButton("Jump"))
        //    //    moveDirection.y = jumpSpeed;

        //}
        //moveDirection.y -= gravity * Time.deltaTime;
        //controller.Move(moveDirection * Time.deltaTime);
    }
}
