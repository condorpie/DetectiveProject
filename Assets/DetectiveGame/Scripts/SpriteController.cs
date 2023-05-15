using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class SpriteController : MonoBehaviour
{
    public Image character;

    void Start()
    {
        character = GetComponent<Image>();
    }

    [YarnCommand("show_sprite")]
    public void ShowSprite()
    {
        character.enabled = true;
    }

    [YarnCommand("hide_sprite")]
    public void HideSprite()
    {
        character.enabled = false;
    }
}

