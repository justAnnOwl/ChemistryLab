using UnityEngine;

public class FlaskOutlineActivate : MonoBehaviour
{// DB0009
    // public GameObject tempGameObject;

    public static Outline lastObjectOutline;
    //  private static GameObject lastOutlineObject;

    private Outline _outline;
    
    private void Awake()
    {
         // lastObjectOutline = tempGameObject.GetComponent<Outline>();
         // lastObjectOutline.enabled = false;

         _outline = GetComponent<Outline>();
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        Color color;

        if (collision.gameObject.CompareTag("Tube"))
            color = Color.green;
        else if (collision.gameObject.CompareTag("GameObject"))
            color = Color.red;
        else
            return;

        lastObjectOutline = collision.gameObject.GetComponent<Outline>();
        lastObjectOutline.enabled = true;
        lastObjectOutline.OutlineColor = color;

        EnableOutline(color);
    }

    private void EnableOutline(Color color)
    {
        _outline.enabled = true;
        _outline.OutlineColor = color;
    }

    private void OnCollisionExit(Collision _)
    {
        _outline.enabled = false;

        if (lastObjectOutline != null)
            lastObjectOutline.enabled = false;
    }
}
