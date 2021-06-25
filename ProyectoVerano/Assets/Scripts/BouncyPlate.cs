using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyPlate : MonoBehaviour
{

    public float strength = 5; 

    private void OnTriggerEnter(Collider other)
    {
        other.attachedRigidbody.AddForce(Vector3.up * strength, ForceMode.Impulse);
    }
}
