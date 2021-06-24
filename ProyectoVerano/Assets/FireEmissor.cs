using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEmissor : MonoBehaviour
{
    public float interval = 2f;
    private float time;
    private ParticleSystem ps;

    private bool isOn;

    void Start()
    {
        ps = this.GetComponent<ParticleSystem>();
        time = 0;
    }

    void Update()
    {
        if (time > 0) time -= Time.deltaTime;
        else
        {
            time = interval;
            if (isOn) ps.Play();
            else ps.Stop();
            isOn = !isOn;
        }
    }

    void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerMovement>().Morir();
        }
    }
}
