using UnityEngine;
using UnityEngine.Audio;

public class Mute : MonoBehaviour
{
    [SerializeField] private AudioMixer _mixer;

    private bool _isMute = false;
    private int _minVolume = -60;
    private int _maxVolume = 0;

    public bool IsMute => _isMute;

    public void OnValueChanged()
    {
        _isMute =! _isMute;

        if (_isMute)
            _mixer.SetFloat("Master", _minVolume);
        else
            _mixer.SetFloat("Master", _maxVolume);
    }
}
