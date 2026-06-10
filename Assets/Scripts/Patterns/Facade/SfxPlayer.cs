using UnityEngine;

public class SfxPlayer
{
    private AudioSource _source;

    public SfxPlayer(AudioSource source)
    {
        _source = source;
    }

    public void PlayOneShot(AudioClip clip)
    {
        _source.PlayOneShot(clip);
    }

    public void SetVolume(float volume)
    {
        _source.volume = volume;
    }
}