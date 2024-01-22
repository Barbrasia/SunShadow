using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "CameraEffectsInfo", menuName = "ScriptableObjects/CameraEffectsInfo", order = 1)]
public class CameraEffectsInfo : ScriptableObject
{
    public bool shouldApplySunEffect;   
}
