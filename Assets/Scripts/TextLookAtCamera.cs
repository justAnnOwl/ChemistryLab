using UnityEngine;

public class TextLookAtCamera : MonoBehaviour
{
    [SerializeField] private Transform _lookAt;

    private void Awake()
    {
        transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1f, 1f, 1f));
    }

    private void Update()
    {
        transform.LookAt(_lookAt.position);
    }
}
