using UnityEngine;

public class GetObjectName : MonoBehaviour
{
    public void OnMouseDown()
    {
        AdviceActivity.Enable(true);
        AdviceActivity.SetAdviceText(name);
    }
}
