using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float vel = 1f;
    Rigidbody rb;

    CameraPosition camPos;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        camPos = FindObjectOfType<CameraPosition>();
    }


    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        switch (camPos.getPositionCamera())
        {
            case 0:
                rb.velocity = new Vector3(h * vel, 0, 0);
                break;
            case 1:
                rb.velocity = new Vector3(0, 0, h * vel);
                break;
            case 2:
                rb.velocity = new Vector3(h * vel, 0, 0);
                break;
            case 3:
                rb.velocity = new Vector3(0, 0, h * vel);
                break;
        }
        
    }
}
