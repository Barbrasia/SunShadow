using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnvironmentInfo : MonoBehaviour
{
    public CameraEffectsInfo cameraEffectsInfo;

    void Update()
    {
        
        if (SunShadowDetector.Instance.IsInSunLight())
        {
            Debug.Log("Player is in the sun in the graphics scene.");
            cameraEffectsInfo.shouldApplySunEffect = true;
        }
        else
        {
            Debug.Log("Player is in shadow in the graphics scene.");
            cameraEffectsInfo.shouldApplySunEffect = false;
        }
    }
}
