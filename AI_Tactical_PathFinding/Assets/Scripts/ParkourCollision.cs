using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkourCollision : MonoBehaviour
{
    public AudioClip Parkour;

    private void OnTriggerEnter(Collider collider)
    {
        AudioSource ac = GetComponent<AudioSource>();
        ac.PlayOneShot(Parkour);
    }
}
