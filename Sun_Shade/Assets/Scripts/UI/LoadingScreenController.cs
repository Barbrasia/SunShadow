using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScreenController : MonoBehaviour
{
    public Slider slider;
    public Button startButton;
    public float duration = 1f;

    public string sceneToLoad1;
    public string sceneToLoad2;

    private void Awake()
    {
        slider.gameObject.SetActive(false);
    }
    private void Start()
    {
        startButton.onClick.AddListener(StartSliderAnimation);
    }

    private IEnumerator AnimateSliderCoroutine()
    {
        float startTime = Time.time;
        float elapsedTime = 0f;

        startButton.gameObject.SetActive(false);
        slider.gameObject.SetActive(true);

        while (elapsedTime < duration)
        {
            float t = elapsedTime / duration;
            float animatedValue = Mathf.Lerp(0f, 1f, t);

            slider.value = animatedValue;

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        slider.value = 1f;

        SceneManager.LoadScene(sceneToLoad1);
        SceneManager.LoadScene(sceneToLoad2, LoadSceneMode.Additive);
    }

    private void StartSliderAnimation()
    {
        StartCoroutine(AnimateSliderCoroutine());
    }
}
