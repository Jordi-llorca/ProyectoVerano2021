using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{

    public Camera cam;
    public Transform [] positions;
    private int actualPos = 0;

    public int getPositionCamera() { return actualPos; }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)){
            actualPos = ((actualPos - 1) + 4) % 4;
            cam.transform.SetPositionAndRotation(positions[actualPos].position, positions[actualPos].rotation);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            actualPos = ((actualPos + 1) + 4) % 4;
            cam.transform.SetPositionAndRotation(positions[actualPos].position, positions[actualPos].rotation);
        }
    }
}
