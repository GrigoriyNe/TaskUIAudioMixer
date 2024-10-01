using UnityEngine;

public class Mute : MonoBehaviour
{
    [SerializeField] private AudioSource [] _audioSource;

    public void OnValueChanged()
    {
        foreach (AudioSource audioSource in _audioSource)
            audioSource.mute = !audioSource.mute;
    }
}
