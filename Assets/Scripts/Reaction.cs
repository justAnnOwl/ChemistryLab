using System.Collections;
using UnityEngine;

public class Reaction : MonoBehaviour
{
    public Material TubeMaterial;
    public Material FlaskMaterial;

    public float  ScorostPerelivania = 0.2f;
    public float SokolkoSekundLit = 2f;
    public float SkolkoNalit = 2f;

    private float _zapolnenostProbirki;
    private float _zapolnenostButilki;
    
    private void Awake() {

        _zapolnenostProbirki = TubeMaterial.GetFloat("Fill Level");
        _zapolnenostButilki = FlaskMaterial.GetFloat("Fill Level");
    }

    public void NachatPerelivanie()
    {
        var vremyaNalivania = SkolkoNalit / ScorostPerelivania / SokolkoSekundLit;
        
        StartCoroutine(Nalivay(vremyaNalivania));
    }

    private IEnumerator Nalivay(float vremyaNalivania)
    {
        var currentTime = 0f;

        while (currentTime < SokolkoSekundLit)
        {
            _zapolnenostProbirki += ScorostPerelivania;
            _zapolnenostButilki -= ScorostPerelivania;
            
            TubeMaterial.SetFloat("Fill Level", _zapolnenostProbirki);
            FlaskMaterial.SetFloat("Fill Level", _zapolnenostButilki);

            yield return new WaitForSeconds(vremyaNalivania);

            currentTime += vremyaNalivania;
        }
    }
}
