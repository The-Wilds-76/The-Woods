using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCMovement : MonoBehaviour
{

    private float speed = 0.03f; //Base speed

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 position = this.transform.position;
            position.z = position.z + speed;
            this.transform.position = position;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Vector3 position = this.transform.position;
            position.x = position.x - speed;
            this.transform.position = position;
        }

        if (Input.GetKey(KeyCode.S))
        {
            Vector3 position = this.transform.position;
            position.z = position.z - speed;
            this.transform.position = position;
        }

        if (Input.GetKey(KeyCode.D))
        {
            Vector3 position = this.transform.position;
            position.x = position.x + speed;
            this.transform.position = position;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 0.06f;
        }

        if (!Input.GetKey(KeyCode.LeftShift))
        {
            speed = 0.03f;
        }
    }
}
