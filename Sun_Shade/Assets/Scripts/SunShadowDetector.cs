using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunShadowDetector : MonoBehaviour
{
    public static SunShadowDetector Instance { get; private set; }

    private Color cameraBackgroundColor;
    private RenderTexture cameraRenderTexture;

    private void Awake()
    {

        Instance = this;

        cameraBackgroundColor = GetComponent<Camera>().backgroundColor;
        cameraRenderTexture = GetComponent<Camera>().targetTexture;
    }

    public bool IsInSunLight()
    {
        RenderTexture.active = cameraRenderTexture;

        Texture2D texture2D = new Texture2D(cameraRenderTexture.width, cameraRenderTexture.height, TextureFormat.ARGB32, false);
        Rect rect = new Rect(0, 0, cameraRenderTexture.width, cameraRenderTexture.height);
        texture2D.ReadPixels(rect, 0, 0);

        Color skyColor = texture2D.GetPixel(0, 0);

        RenderTexture.active = null;

        float alphaMax = .1f;
        return skyColor.a < alphaMax;
    }

    private void Update()
    {
        if (IsInSunLight())
        {
            Debug.Log("InSun");
        }
        else
        {
            Debug.Log("InShadow");
        }
        
    }
}
