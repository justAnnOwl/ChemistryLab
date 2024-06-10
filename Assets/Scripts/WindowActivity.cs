using UnityEngine;

public class WindowActivity : MonoBehaviour
{
    public int count;
    private int counter = 0;
    public GameObject[] gameObject;

    private void Start()
    {
        gameObject = new GameObject[transform.childCount];
        for (var i = 0; i < count; i++)
        {
            gameObject[i] = transform.GetChild(i).gameObject;
            gameObject[i].SetActive(false);
        }
    }

/*void setActive(){
    if(counter<count){
   // gameObject.SetActive(true);
    counter++;
    }/*
   }/*
   void setInactive(){

    gameObject.SetActive(false);
    counter++;
   }*/
}
