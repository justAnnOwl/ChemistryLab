using UnityEngine;

public class SmoothAppearence : MonoBehaviour
{
    public SpriteRenderer image;

    private void Start()
    {
        image = GetComponent<SpriteRenderer>();
    }

    private void Update()
     {
         var fullColor = Color.white;
         var emptyColor = Color.white;
         fullColor.a = 1;
         emptyColor.a = 0;
         image.color = Color.Lerp(fullColor, emptyColor, Mathf.Abs(Time.time));

     }
    /*IEnumerator Fade()
    {
        Color c = GetComponent<Renderer>().material.color;
        for (float alpha = 0; alpha <= 1f; alpha = 0.1f)
        {
            c.a = alpha;
            GetComponent<Renderer>().material.color = c;
            yield return null;
        }
    }
    void Appear()
    {
        StartCoroutine(Fade());

    }*/
}
