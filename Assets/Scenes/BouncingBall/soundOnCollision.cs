using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundOnCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip bounceSound;
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource> ().clip = bounceSound;
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision other)
    {
        GetComponent<AudioSource> ().Play ();
    }
}
