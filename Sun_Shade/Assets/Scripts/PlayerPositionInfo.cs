using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPositionInfo : MonoBehaviour
{
    public static PlayerPositionInfo Instance { get; private set; }
    public Vector3 objectPosition;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        objectPosition = transform.position;
    }

}
