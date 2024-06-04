using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmoothAppearence : MonoBehaviour
{

    public SpriteRenderer image;

    void Start()
    {
        image = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Color fullColor = Color.white;
        Color emptyColor = Color.white;
        fullColor.a = 1;
        emptyColor.a = 0;
        image.color = Color.Lerp(fullColor, emptyColor, Mathf.Abs(Time.time));

    }
}
