using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hielo : MonoBehaviour
{
    public float velocity = 10f;
    private void OnTriggerStay(Collider other)
    {
        GameObject res = other.gameObject;
        //other.attachedRigidbody.AddForce(res.transform.right, ForceMode.Impulse);
        other.gameObject.GetComponent<PlayerMovement>().blockMovement(true);
        other.attachedRigidbody.MovePosition(other.attachedRigidbody.position + res.transform.right * velocity * Time.deltaTime);
    }
    private void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent<PlayerMovement>().blockMovement(false);
    }
}
