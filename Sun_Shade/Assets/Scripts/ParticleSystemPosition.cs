using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemPosition : MonoBehaviour
{
    public ParticleSystem fire;

    private void Start()
    {
        if (fire == null)
        {
            fire = GetComponent<ParticleSystem>();
        }
    }

    private void Update()
    {
        Vector3 playerObjectPosition = PlayerPositionInfo.Instance.objectPosition;

        transform.position = new Vector3(playerObjectPosition.x, transform.position.y, playerObjectPosition.z);

        if (SunShadowDetector.Instance.IsInSunLight())
        {
            Debug.Log("in the sun");
            if (!fire.isPlaying)
            {
                fire.Play();
            }
        }
        else
        {
            Debug.Log("in shadow");
            if (fire.isPlaying)
            {
                fire.Stop();
            }
        }
    }
}
