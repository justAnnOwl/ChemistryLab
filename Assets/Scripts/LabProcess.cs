using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LabProcess : MonoBehaviour
{
public bool adviceStatus;
private String[] adviceText;
private String tempAdvice;

   public void changeAdviceStatus()
    {
        adviceStatus=!adviceStatus;
    }
    // Start is called before the first frame update
    void Start()
    {

        adviceStatus=false;
        adviceText=new String[3];
        adviceText[0]="Серная кислота (VI) (H₂SO₄) — неорганическое химическое соединение, относящееся к группе кислородных кислот, построенное из центрально расположенного атома серы (S), соединенного одинарными ковалентными связями с двумя гидроксильными группами (ОН) и двойными ковалентными связями.Серная кислота (VI) (H₂SO₄) — неорганическое химическое соединение, относящееся к группе кислородных кислот, построенное из центрально расположенного атома серы (S), соединенного одинарными ковалентными связями с двумя гидроксильными группами (ОН) и двойными ковалентными связями. с двумя атомами кислорода (О).";
        adviceText[1]="this is BaCl2Flask";
        adviceText[2]="this is Na2SO4Flask";
    }

    // Update is called once per frame
   public void showAdvice()
    {
        if(adviceStatus==true){
            switch(this.name){
                case "H2SO4Flask": tempAdvice=adviceText[0];
                    break;
                case "BaCl2Flask": tempAdvice=adviceText[1];
                    break;
                case "Na2SO4Flask": tempAdvice=adviceText[2];
                    break;   
            }
           
        }
    }
}
