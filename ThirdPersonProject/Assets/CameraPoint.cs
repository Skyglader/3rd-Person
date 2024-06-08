using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPoint : MonoBehaviour
{
    public GameObject playerShoulder;

    void Update()
    {
        transform.position = playerShoulder.transform.position;
    }
}
