using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class ScreenShake : MonoBehaviour
{
    public float shakeDuration = 0.5f;
    public float shakeIntensity = 0.1f;

    [YarnCommand("screen_shake02")]
    public void ShakeScreen()
    {
        print("SHAKE");
        StartCoroutine(Shake());
    }

    private IEnumerator Shake()
    {
        float t = 0;

        Vector3 originalPosition = transform.position;

        while (t < shakeDuration)
        {
            t += Time.deltaTime;

            float x = originalPosition.x + Random.Range(-1f, 1f) * shakeIntensity;
            float y = originalPosition.y + Random.Range(-1f, 1f) * shakeIntensity;

            transform.position = new Vector3(x, y, originalPosition.z);

            yield return null;
        }

        transform.position = originalPosition;
    }
}
