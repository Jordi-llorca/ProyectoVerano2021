using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class razor : MonoBehaviour
{
    public float Speed = 15;
    Rigidbody rb;

    public Transform RightPoint;
    public Transform LeftPoint;

    bool toRight = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if(toRight)
        {
            rb.MovePosition(Vector3.MoveTowards(transform.position, RightPoint.position, Time.deltaTime * Speed));
            if (transform.position.Equals(RightPoint.position)) toRight = false;
        }
        else
        {
            rb.MovePosition(Vector3.MoveTowards(transform.position, LeftPoint.position, Time.deltaTime * Speed));
            if (transform.position.Equals(LeftPoint.position)) toRight = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerMovement>().Morir();
        }
    }
}
