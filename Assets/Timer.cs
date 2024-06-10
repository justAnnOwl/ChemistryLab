using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public GameObject gameObject;
    float timeInSec=60;
    void Start()
    {
        StartCoroutine("ExecuteAfterTime", timeInSec);
    }

    
    IEnumerator ExecuteAfterTime(float timeInSec)
    {
        yield return new WaitForSeconds(timeInSec);
        gameObject.SetActive(true);
    }
}
