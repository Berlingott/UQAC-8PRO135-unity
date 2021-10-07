using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerLevel2 : MonoBehaviour
{
    public int countdownTime;
    public LoadingScreenEnter loadingfunction;

    private void Start()
    {
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
        while (countdownTime > 0)
        {

            yield return new WaitForSeconds(1f);

            countdownTime--;
        }
        
        loadingfunction.LoadNextLevel();
    }
}
