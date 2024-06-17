using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateAnimation : MonoBehaviour
{
  public int animationCounter;
  public Animator animator;
  public GameObject qr;
  public GameObject reactionText;
  //private Animator animator;
  //public Animation animation;

  // public GameObject gameObject_1;
  //public GameObject gameObject_2;

  /*void Awake()
  {
    animator.GetComponent<Animator>();
  }*/
  private void OnCollisionEnter(Collision collision)
  {
    // свечение 
    //Reaction reaction = new Reaction();

    if (collision.gameObject.tag == "Tube") //запуск анимации
    {
      // if(animationCounter>0){
      //animation.Play();
      animator.SetBool("isCollision", true);
      //      reactionText.SetActive(true);
      Invoke("chtoUgodno", 1f);
      //animationCounter--;
      print("Collision detected");
      //}
      this.GetComponent<Collider>().enabled = false;
      this.GetComponent<Outline>().enabled = false;
      //   Invoke("qrAcrive", 6f);
      // reaction.NachatPerelivanie();
    }
  }

  private void chtoUgodno()
  {
    animator.SetBool("isCollision", false);
  }
  /*private void qrAcrive(){
    print("qrActive");
    qr.SetActive(true);
  }*/
  /*void Update()
  {
    if (animator.GetBool("isCollision"))
    {
      animator.applyRootMotion = true;
    }
    else
      animator.applyRootMotion = false;
  }*/
}
