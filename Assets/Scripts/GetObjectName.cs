using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetObjectName : MonoBehaviour
{
    public void OnMouseDown()
    {
        AdviceActivity.Enable(true);
        AdviceActivity.SetAdviceText(this.name);
    }
}