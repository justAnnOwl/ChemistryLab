using UnityEngine;

public class Activity : MonoBehaviour
{
    public GameObject gameObject;

    private void Start()
    {
        gameObject.SetActive(false);
    }




/*void setActive(){
    if(counter<count){
   // gameObject.SetActive(true);
    counter++;
    }
   }/*
   void setInactive(){

    gameObject.SetActive(false);
    counter++;
   }*/
}
