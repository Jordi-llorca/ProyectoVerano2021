using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 15;
    public float rotationSpeed = 4;
    Rigidbody rb;

    CameraPosition camPos;
    public GameObject cam;

    Vector3 dir;

    bool canMove = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        camPos = FindObjectOfType<CameraPosition>();
    }

    void Update()
    {
        if (canMove) movement();
    }

    void movement()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        dir = new Vector3(-v, 0, h);

        switch (camPos.getPositionCamera())
        {
            case 0:
                dir = new Vector3(-v, 0, h);
                break;
            case 1:
                dir = new Vector3(-h, 0, -v);
                break;
            case 2:
                dir = new Vector3(v, 0, -h);
                break;
            case 3:
                dir = new Vector3(h, 0, v);
                break;
        }


        if (v != 0 || h != 0) rb.MovePosition(rb.position + transform.right * Mathf.Max(Mathf.Abs(h), Mathf.Abs(v)) * movementSpeed * Time.deltaTime);

        if (dir != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(
                transform.rotation,
                Quaternion.LookRotation(dir),
                Time.deltaTime * rotationSpeed
            );
        }
    }

    public void blockMovement(bool move){ canMove = !move; }

    public Vector3 getDirection() { return dir; }

    public void Morir()
    {
        FindObjectOfType<LevelLoader>().ReloadLevel();
    }
}
