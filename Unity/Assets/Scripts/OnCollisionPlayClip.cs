using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

class OnCollisionPlayClip : MonoBehaviour
{
    public float impactModifier;

    public AudioSource source;

    private void Awake()
    {
        if (source == null)
            source = GetComponent<AudioSource>();
        if (source == null)
            Debug.LogError("There needs to be an AudioSource on this object!", this);
    }

    public void OnCollision(Collision collision)
    {
        if (source == null)
            return;

        source.pitch = collision.relativeVelocity.magnitude * impactModifier;
        source.volume = collision.relativeVelocity.magnitude * impactModifier;
        source.Play();
    }
}