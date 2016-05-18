using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

class OnCollisionPlayClip : MonoBehaviour
{
    public float impactModifier;

    public AudioClip clip;
    public AudioSource source;

    public float delay = .1f;
    private float timer;

    private void Awake()
    {
        if (source == null)
            source = GetComponent<AudioSource>();
        if (source == null)
            Debug.LogError("There needs to be an AudioSource on this object!", this);

        if (clip == null)
            clip = source.clip;
    }

    public void Update()
    {
        if (timer > 0)
            timer -= Time.deltaTime;
    }

    public void OnCollision(Collision collision)
    {
        if (source == null && timer <= 0)
            return;
        
        source.volume = collision.relativeVelocity.magnitude /impactModifier;
        source.PlayOneShot(clip);
        timer = delay;
    }
}