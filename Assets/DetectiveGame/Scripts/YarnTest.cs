using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class YarnTest : MonoBehaviour
{
    [YarnCommand("fade_camera")]
    public void FadeCamera() {
        Debug.Log("Fading the camera!");
    }
}
