using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AdviceActivity : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _adviceText;
    [SerializeField] private bool _isAdviceModeActive;
    [SerializeField] private Button _closeButton;

    private static AdviceActivity _instance;

    private void Awake()
    {
        _instance = this;
        _isAdviceModeActive = false;
    }

    public static void SetAdviceText(string objectName)
    {
        if (!_instance._isAdviceModeActive)
            return;

        _instance._adviceText.text = objectName switch
        {
            "H2SO4Flask" => "Серная кислота (H2SO4) обладает характерными свойствами кислот и является сильным окислителем. Это наиболее активная неорганическая кислота с температурой плавления 10°C. Кислота закипает при 296°C с выделением воды и оксида серы SO3. Способна поглощать пары воды, поэтому её используют для осушения газов.",
            "BaCl2Flask" => "Хлорид бария  существует в безводной и дигидратированной форме.\nОн состоит из бесцветных кристаллов, которые растворимы в воде, используется и в лабораториях в качестве химического реагента для осаждения растворимых сульфатов. это одна из наиболее растворимых в воде солей бария.\nТоксичен и придает пламени желто-зеленый цвет.",
            "Na2SO4Flask" => "Сульфат натрия  - неорганическое соединение с формулой Na2SO4 и связанные с ним гидраты.\nВсе формы представляют собой белые твердые вещества, которые хорошо растворяются в воде.\nОн считается одним из основных продаваемых химических продуктов.\nВ настоящее время он используется в основном для производства моющих средств.",
            _ => _instance._adviceText.text
        };
    }

    public static void Enable(bool state) 
    {
        if (_instance._isAdviceModeActive)
            _instance.gameObject.SetActive(state);
    }

    public void SetAdviceActivityMode()
    {
        _isAdviceModeActive = !_isAdviceModeActive;
    }

    public void SetAdviceCursor()
    {
        if (_isAdviceModeActive)
        {

        }
    }
}
