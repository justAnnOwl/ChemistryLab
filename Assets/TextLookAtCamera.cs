using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextLookAtCamera : MonoBehaviour
{
    [SerializeField] private Transform _lookAt;
    void Update()
    {
        transform.LookAt(Vector3.Scale(_lookAt.position, Vector3.forward*-1));
       
    }
}
