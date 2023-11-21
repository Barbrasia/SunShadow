using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunShadowCameraRotation : MonoBehaviour
{
    [SerializeField] private Light directionalLight;

    void Update()
    {
        transform.forward = -directionalLight.transform.forward;
    }
}
