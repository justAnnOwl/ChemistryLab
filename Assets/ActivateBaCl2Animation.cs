using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBaCl2Animation : MonoBehaviour
{
    public Animator animator;
    public GameObject qr;
    public GameObject reactionText_H2SO4;
    public GameObject reactionText_Na2SO4;
    private int textCounter = 0;
    public GameObject sediment_1;
    public GameObject sediment_2;
    void Awake()
    {
        qr = GameObject.Find("qr-code");
        reactionText_H2SO4 = GameObject.Find("reactionText_H2SO4");
        reactionText_Na2SO4 = GameObject.Find("reactionText_Na2SO4");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Tube") //запуск анимации
        {
            animator.SetBool("isCollision", true);
            reactionText_H2SO4.SetActive(true);
            Invoke("chtoUgodno", 1f);
            this.GetComponent<Outline>().enabled = false;
            textCounter++;
            sediment_1.SetActive(true);
            if (textCounter == 2)
            {
                this.GetComponent<Collider>().enabled = false;
                sediment_2.SetActive(true);
                reactionText_Na2SO4.SetActive(true);
                  Invoke("chtoUgodno", 1f);
                Invoke("qrAcrive", 6f);
            }
        }
    }
    private void chtoUgodno()
    {
        animator.SetBool("isCollision", false);
    }
    private void qrAcrive()
    {
        print("qrActive");
        qr.SetActive(true);
    }
}
