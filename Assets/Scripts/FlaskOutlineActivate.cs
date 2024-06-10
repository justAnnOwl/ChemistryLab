using UnityEngine;

public class FlaskOutlineActivate : MonoBehaviour
{// DB0009
    public static Outline lastObjectOutline;
    public GameObject tempGameObject;
    //  private static GameObject lastOutlineObject;

    private void Awake()
    {
      lastObjectOutline = tempGameObject.GetComponent<Outline>();
      lastObjectOutline.enabled = false;
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Tube"))
        {
             lastObjectOutline = collision.gameObject.GetComponent<Outline>();
             lastObjectOutline.enabled = true;
             lastObjectOutline.OutlineColor = Color.green;

             var thisOutline = this.GetComponent<Outline>();
             thisOutline.enabled = true;
             thisOutline.OutlineColor = Color.green;
        }
        else if (collision.gameObject.CompareTag("GameObject"))
        {
             lastObjectOutline = collision.gameObject.GetComponent<Outline>();
             lastObjectOutline.enabled = true;
             lastObjectOutline.OutlineColor = Color.red;

             var thisOutline = GetComponent<Outline>();
             thisOutline.enabled = true;
             thisOutline.OutlineColor = Color.red;
        }
  }

    private void OnCollisionExit(Collision collision)
    {
        var thisOutline = GetComponent<Outline>();
        thisOutline.enabled = false;
        lastObjectOutline.enabled = false;
    }
}
