using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    [SerializeField] string[] volumeParameters;
    [SerializeField] AudioMixer _audioMixer;
    [SerializeField] Slider _slider;

    private float _volumeValue;

    private const float _multiplier = 20f;

    private void Awake()
    {
        _slider.onValueChanged.AddListener(HandleSliderValueChanged);
    }

    private void Start()
    {
        for (int i = 0; i < volumeParameters.Length; i++) 
        {
            _volumeValue = PlayerPrefs.GetFloat(volumeParameters[i], Mathf.Log10(_slider.value) * _multiplier);
        }

        _slider.value = Mathf.Pow(10f, _volumeValue / _multiplier);
    }

    private void HandleSliderValueChanged(float value) 
    {
        _volumeValue = Mathf.Log10(value) * _multiplier;
        for (int i = 0; i < volumeParameters.Length; i++)
        {
            _audioMixer.SetFloat(volumeParameters[i], _volumeValue);
        }
    }

    private void OnDisable()
    {
        for (int i = 0; i < volumeParameters.Length; i++) 
        {
            PlayerPrefs.SetFloat(volumeParameters[i], _volumeValue);
        }

    }
}
