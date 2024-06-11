using System.Collections;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public GameObject gameObject;
    private const float TimeInSec = 60;

    private void Start()
    {
        StartCoroutine(nameof(ExecuteAfterTime), TimeInSec);
    }
    
    IEnumerator ExecuteAfterTime(float timeInSec)
    {
        yield return new WaitForSeconds(timeInSec);
        gameObject.SetActive(true);
    }
}
