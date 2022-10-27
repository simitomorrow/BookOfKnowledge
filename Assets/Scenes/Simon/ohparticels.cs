using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ohparticels : MonoBehaviour
{
    public ParticleSystem particles;
    private bool trigger;

    private void Start()
    {
        particles.Stop();
    }
    public void toggleParticles()
    {
        trigger = !trigger;
        if (trigger)
        {
            particles.Play();
        }
        else
        {
            particles.Stop();
        }
    }
}
