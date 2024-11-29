using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RendomPipeMap : MonoBehaviour
{
    public GameObject pipe;
    public float pipeSpeed = 0.005f;

    void Update()
    {
        pipe.transform.position -= Vector3.right * pipeSpeed;
    }
}