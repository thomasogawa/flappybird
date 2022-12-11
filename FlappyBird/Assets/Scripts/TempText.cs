using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TempText : MonoBehaviour
{
    private Text tempText;

    public float fadeDuration = 2.0f;
    public float velocity = 2.0f;

    void Start()
    {
        tempText = this.GetComponent<Text>();
        StartCoroutine(Fade());
        StartCoroutine(Float());
    }
    
    IEnumerator Fade()
    {
        float fadespeed = (float)1.0 / fadeDuration;
        Color c = tempText.color;
        
        for(float t = 0.0f; t < 1.0f; t += Time.deltaTime * fadespeed)
        {
            c.a = Mathf.Lerp(1, 0, t);
            tempText.color = c;
            yield return true;
        }

        Destroy(this.gameObject);
    }
    
    IEnumerator Float()
    {
        while (true)
        {
            transform.position += Vector3.up * velocity * Time.deltaTime;
            yield return null;
        }
    }
}
