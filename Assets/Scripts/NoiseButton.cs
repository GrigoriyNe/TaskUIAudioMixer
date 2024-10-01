using UnityEngine;

public class NoiseButton : MonoBehaviour
{
    [SerializeField] private AudioSource _soung;

    public void Play()
    {
        _soung.Play();
    }
}
