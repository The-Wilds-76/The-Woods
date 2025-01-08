using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCCameraPos : MonoBehaviour
{

    public Transform cameraPosition;

    // Update is called once per frame
    void Update()
    {
        transform.position = cameraPosition.position;
    }
}
