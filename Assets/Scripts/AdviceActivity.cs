using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class AdviceActivity : MonoBehaviour
{
    public TextMeshProUGUI adviceText;
    public bool isAdviceModeActive;
    private static AdviceActivity instance;
    public Button closeButton;
    void Awake()
    {
        instance = this;
        isAdviceModeActive = false;
    }


    public static void SetAdviceText(string objectName)
    {

        switch (objectName)
        {
            case "H2SO4Flask": instance.adviceText.text= "Серная кислота (H2SO4) обладает характерными свойствами кислот и является сильным окислителем. Это наиболее активная неорганическая кислота с температурой плавления 10°C. Кислота закипает при 296°C с выделением воды и оксида серы SO3. Способна поглощать пары воды, поэтому её используют для осушения газов.";
                break;
            case "BaCl2Flask": instance.adviceText.text= "Хлорид бария  существует в безводной и дигидратированной форме.\nОн состоит из бесцветных кристаллов, которые растворимы в воде, используется и в лабораториях в качестве химического реагента для осаждения растворимых сульфатов. это одна из наиболее растворимых в воде солей бария.\nТоксичен и придает пламени желто-зеленый цвет.";
                break;
            case "Na2SO4Flask": instance.adviceText.text= "Сульфат натрия  - неорганическое соединение с формулой Na2SO4 и связанные с ним гидраты.\nВсе формы представляют собой белые твердые вещества, которые хорошо растворяются в воде.\nОн считается одним из основных продаваемых химических продуктов.\nВ настоящее время он используется в основном для производства моющих средств.";
                break;
        }
    }
    public static void Enable(bool state) 
    {
        if(instance.isAdviceModeActive==true)
        instance.gameObject.SetActive(state);
    }
    public void SetAdviceActivityMode(){
    isAdviceModeActive=!isAdviceModeActive;
    }
    public void SetAdviceCursor(){
        if(isAdviceModeActive){
            
        }
    }
    private void Update(){
        
    }
}
