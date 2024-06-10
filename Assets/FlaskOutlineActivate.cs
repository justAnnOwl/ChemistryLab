using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlaskOutlineActivate : MonoBehaviour
{// DB0009

  public static Outline lastObjectOutline;
  public GameObject tempGameObject;
 //  private static GameObject lastOutlineObject;
void Awake(){
   lastObjectOutline = tempGameObject.GetComponent<Outline>();
      lastObjectOutline.enabled = false;
}
  void Update(){

  }
  private void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.tag == "Tube")
    {
      lastObjectOutline = collision.gameObject.GetComponent<Outline>();
      lastObjectOutline.enabled = true;
      lastObjectOutline.OutlineColor = Color.green;

      Outline thisOutline;
      thisOutline = this.GetComponent<Outline>();
      thisOutline.enabled = true;
      thisOutline.OutlineColor = Color.green;
    }
   else  if (collision.gameObject.tag == "GameObject")
    {
      lastObjectOutline = collision.gameObject.GetComponent<Outline>();
      lastObjectOutline.enabled = true;
      lastObjectOutline.OutlineColor = Color.red;

      Outline thisOutline;
      thisOutline = this.GetComponent<Outline>();
      thisOutline.enabled = true;
      thisOutline.OutlineColor = Color.red;
    }
  }
  private void OnCollisionExit(Collision collision){
         Outline thisOutline;
     thisOutline = this.GetComponent<Outline>();
     thisOutline.enabled = false;
     lastObjectOutline.enabled=false;
  }
}
