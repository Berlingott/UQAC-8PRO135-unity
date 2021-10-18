using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningCollisionCylinder : MonoBehaviour
{
    // Start is called before the first frame update
    
    public LoadingScreenEnter loadingfunction;
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision other)
    {
        loadingfunction.LoadNextLevel();
    }
}
