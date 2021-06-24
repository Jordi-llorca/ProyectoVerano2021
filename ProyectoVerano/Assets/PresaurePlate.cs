using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresaurePlate : MonoBehaviour
{
    [SerializeField]
    GameObject affectedObject;

    private void OnTriggerEnter(Collider other)
    {
        affectedObject.SetActive(false);
    }
}
