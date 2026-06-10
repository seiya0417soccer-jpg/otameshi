using UnityEngine;

public class MusicPlayer
{
    private AudioSource _source;

    public MusicPlayer(AudioSource source)
    {
        _source = source;
    }

    public void Play(AudioClip clip)
    {
        _source.clip = clip;
        _source.Play();
    }

    public void SetVolume(float volume)
    {
        _source.volume = volume;
    }

    public void Stop()
    {
        _source.Stop();
    }
}