using System;
using UnityEngine;

public class LabProcess : MonoBehaviour
{
    public bool adviceStatus;

    private string[] _adviceText;
    private string _tempAdvice;

    public void changeAdviceStatus()
    {
        adviceStatus = !adviceStatus;
    }

    private void Start()
    {
        adviceStatus=false;
        _adviceText=new String[3];
        _adviceText[0]="Серная кислота (VI) (H₂SO₄) — неорганическое химическое соединение, относящееся к группе кислородных кислот, построенное из центрально расположенного атома серы (S), соединенного одинарными ковалентными связями с двумя гидроксильными группами (ОН) и двойными ковалентными связями.Серная кислота (VI) (H₂SO₄) — неорганическое химическое соединение, относящееся к группе кислородных кислот, построенное из центрально расположенного атома серы (S), соединенного одинарными ковалентными связями с двумя гидроксильными группами (ОН) и двойными ковалентными связями. с двумя атомами кислорода (О).";
        _adviceText[1]="this is BaCl2Flask";
        _adviceText[2]="this is Na2SO4Flask";
    }

   public void showAdvice()
    {
        if(adviceStatus)
        {
            _tempAdvice = name switch
            {
                "H2SO4Flask" => _adviceText[0],
                "BaCl2Flask" => _adviceText[1],
                "Na2SO4Flask" => _adviceText[2],
                _ => _tempAdvice
            };
        }
    }
}
