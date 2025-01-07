using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCTorch : MonoBehaviour
{
    public Transform torchPosition;

    // Update is called once per frame
    void Update()
    {
        transform.position = torchPosition.position;
    }
}
