using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tubes2 : MonoBehaviour
{
       

       public int count;
       private int counter =0;
       public GameObject[] gameObject; 
     
            
    // Start is called before the first frame update
    
void setActive(){
    if(counter<count){
    gameObject[counter].SetActive(true);
    counter++;
    }
   }/*
   void setInactive(){

    gameObject.SetActive(false);
    counter++;
   }*/
}
