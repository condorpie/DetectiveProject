using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class BackgroundChange : MonoBehaviour
{
    public Image backgroundImage;

    [YarnCommand("change_background")]
    public void ChangeBackground(string spriteName)
    {
        Sprite newSprite = Resources.Load<Sprite>(spriteName);
        if (newSprite != null)
        {
            backgroundImage.sprite = newSprite;
        }
        else
        {
            Debug.LogError("Sprite " + spriteName + " not found in Resources folder");
        }
    }
}
