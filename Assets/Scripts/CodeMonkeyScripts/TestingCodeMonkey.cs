using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingCodeMonkey : MonoBehaviour
{
    Camera cam;
    GridCodeMonkey grid;
    void Start()
    {
        cam = Camera.main;
        grid = new GridCodeMonkey(7, 5, 10f, new Vector3(20,0));
        GridCodeMonkey grid2 = new GridCodeMonkey(4, 4, 5f, new Vector3(8, 5));
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            grid.SetValue(GetMouseWorldPosition(), 56);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(grid.GetValue(GetMouseWorldPosition()));
        }
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 vec = GetMouseWorldPositionWithZ(Input.mousePosition, cam);
        vec.z = 0f;
        return vec;
    }

    private Vector3 GetMouseWorldPositionWithZ(Vector3 screenPosition, Camera worldCamera)
    {
        Vector3 worldPosition = worldCamera.ScreenToWorldPoint(screenPosition);
        return worldPosition;
    }
}
