using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PCMovement : MonoBehaviour
{

    private float speed = 0.03f; //Base speed
    public Vector3 jump; //For the actual jump movement
    public float jumpForce = 2.0f; //How high you jump
    public float rotationSpeed = 1.0f; // Rotation speed
    public bool isGrounded; //When on the ground
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
        transform.RotateAround(rb.transform.position, rb.transform.position, 0);
    }

    // Update on collison
    void OnCollisionStay()
    {
        isGrounded = true;
    }

    // Update on lack of collision
    void OnCollisionExit()
    {
        isGrounded = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Forward
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 position = this.transform.position;
            position.z = position.z + speed;
            this.transform.position = position;
        }

        //Right
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 position = this.transform.position;
            position.x = position.x - speed;
            this.transform.position = position;
        }

        //Backwards
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 position = this.transform.position;
            position.z = position.z - speed;
            this.transform.position = position;
        }

        //Left
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 position = this.transform.position;
            position.x = position.x + speed;
            this.transform.position = position;
        }

        //Sprint
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 0.06f;
        }

        if (!Input.GetKey(KeyCode.LeftShift))
        {
            speed = 0.03f;
        }

        //Jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

        //Rotate Left
        if (Input.GetAxis("Mouse X") < 0)
        {
            transform.Rotate(0, (Input.GetAxis("Mouse X")) * rotationSpeed, 0);
        }
        //Rotate Right
        else if (Input.GetAxis("Mouse X") > 0)
        {
            transform.Rotate(0, (Input.GetAxis("Mouse X")) * rotationSpeed, 0);
        }

        //Camera Rotate Up
        if (Input.GetAxis("Mouse Y") < 0)
        {
            transform.RotateAround(rb.transform.position, transform.up, -(Input.GetAxis("Mouse Y")) * Time.deltaTime * rotationSpeed);
        }
        //Camera Rotate Down
        else if (Input.GetAxis("Mouse Y") > 0)
        {
            transform.RotateAround(rb.transform.position, transform.up, -(Input.GetAxis("Mouse Y")) * Time.deltaTime * rotationSpeed);
        }
    }
}
