using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraData : MonoBehaviour
{
    Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
        var height = 2 * cam.orthographicSize;
        var width = height * cam.aspect;

        Debug.Log("Camera height in Units: " + height + " width int Units " + width);
    }
}
