using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] private AudioMixer _mixer;

    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    public void SetCommonVolume()
    {
        _mixer.SetFloat("Master", Mathf.Log10(_slider.value) * 20);
    }

    public void SetMusicVolume()
    {
        _mixer.SetFloat("Music", Mathf.Log10(_slider.value) * 20);
    }

    public void SetBottomVolume()
    {
        _mixer.SetFloat("Bottom", Mathf.Log10(_slider.value) * 20);
    }
}
