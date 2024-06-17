using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTubeAnimation : MonoBehaviour
{
    public Animator animator;
public GameObject fillTube;
   private void OnCollisionEnter(Collision collision)
  {
    // свечение 
 //Reaction reaction = new Reaction();

    if (collision.gameObject.tag == "GameObject") //запуск анимации
    { 
     // if(animationCounter>0){
      //animation.Play();
      animator.SetBool("isCollision", true);
     // Invoke("chtoUgodno", 1f);
      //animationCounter--;
      print("tube detected");
      //}
      fillTube.SetActive(true);

      
   // reaction.NachatPerelivanie();
    }
  }
}
