using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCTorch : MonoBehaviour
{
    public Transform torchPosition;
    public Transform playerCamera;
    public Vector3 offset = new Vector3(0.5f, 0.0f, 1.0f);

    // Update is called once per frame
    void Update()
    {
        //Moves as though the player held it
        torchPosition.position = playerCamera.TransformPoint(offset);
        
        //Moves with the player
        transform.position = torchPosition.position;
    }
}
