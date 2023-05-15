using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class ScreenFade : MonoBehaviour
{
    public Image fadeImage; // reference to the image used for fading

    public float fadeDuration = 1f; // duration of the fade animation

    private bool isFading = false; // flag to track whether a fade is currently in progress

    // public AnimationCurve curve;

    // Coroutine to fade the screen in or out
    private IEnumerator Fade(bool fadeIn)
    {
        isFading = true;

        Color color = fadeImage.color;
        //float targetAlpha = fadeIn ? 0 : 1;
        //float currentAlpha = fadeIn ? 1 : 0;
        float newAlpha;
        float t = 0;

        while (t < fadeDuration)
        {
            t += Time.deltaTime;

            // newAlpha = Mathf.Lerp(currentAlpha, targetAlpha, t / fadeDuration);
            newAlpha = CalculateAlpha(t / fadeDuration);
            //print($"Lerp from {currentAlpha} to {targetAlpha} progress is {t / fadeDuration} making {currentAlpha}");
            color.a = fadeIn ? 1 - newAlpha : newAlpha;
            fadeImage.color = color;

            yield return null;
        }

        isFading = false;
    }

    public virtual float CalculateAlpha(float t)
    {
        return t;
        // return curve.Evaluate(t)
    }

    // Function to start a fade in animation
    [YarnCommand("fade_in")]
    public void FadeIn()
    {
        if (!isFading)
        {
            StartCoroutine(Fade(true));
        }
    }

    // Function to start a fade out animation
    [YarnCommand("fade_out")]
    public void FadeOut()
    {
        print (fadeDuration);
        print ("fadeout");
        if (!isFading)
        {
            StartCoroutine(Fade(false));
        }
    }
}
