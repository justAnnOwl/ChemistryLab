using UnityEngine;

public class Tubes2 : MonoBehaviour
{
    public int count;
    private int counter = 0;
    public GameObject[] gameObject;

    void setActive()
    {
        if (counter < count)
        {
            gameObject[counter].SetActive(true);
            counter++;
        }
    } /*
   void setInactive(){

    gameObject.SetActive(false);
    counter++;
   }*/
}
