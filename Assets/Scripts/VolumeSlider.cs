using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] private AudioMixer _mixer;
    [SerializeField] private Mute _mute;

    private Slider _slider;
    private int _valueMultiplicationForMixerVolume = 20;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    public void SetCommonVolume()
    {
        if (_mute.IsMute == false)
            _mixer.SetFloat("Master", Mathf.Log10(_slider.value) * _valueMultiplicationForMixerVolume);
    }

    public void SetMusicVolume()
    {
        _mixer.SetFloat("Music", Mathf.Log10(_slider.value) * _valueMultiplicationForMixerVolume);
    }

    public void SetBottomVolume()
    {
        _mixer.SetFloat("Bottom", Mathf.Log10(_slider.value) * _valueMultiplicationForMixerVolume);
    }
}
