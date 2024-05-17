using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class AdviceActivity : MonoBehaviour
{
    public TextMeshProUGUI adviceText;
    private bool isAdviceModeActive;
    private static AdviceActivity instance;
    public Button closeButton;
    void Awake()
    {
        instance = this;
       // SetActive(false);
       isAdviceModeActive = false;
    }


    public static void SetAdviceText(string objectName)
    {

        switch (objectName)
        {
            case "H2SO4Flask": instance.adviceText.text= "Это серная кислота";
                break;
            case "BaCl2Flask": instance.adviceText.text= "Это хлорид бария (не_кислота)";
                break;
            case "Na2SO4Flask": instance.adviceText.text= "Это сульфат натрия";
                break;
        }
    }
    public static void Enable(bool state) // активность окна
    {
        if(instance.isAdviceModeActive==true)
        instance.gameObject.SetActive(state);
    }
    public void SetAdviceActivityMode(){
    isAdviceModeActive=!isAdviceModeActive;
    }
    private void Update(){
        
    }
}
