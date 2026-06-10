using System.Collections;
using UnityEngine;

public class AudioFacade : MonoBehaviour
{
    [SerializeField] private AudioSource _musicSource;
    [SerializeField] private AudioSource _sfxSource;

    private MusicPlayer _music;
    private SfxPlayer _sfx;
    private AudioFader _fader;

    private void Awake()
    {
        _music = new MusicPlayer(_musicSource);
        _sfx = new SfxPlayer(_sfxSource);
        _fader = new AudioFader();
    }

    public void PlayMusic(AudioClip clip) => _music.Play(clip);
    public void PlaySfx(AudioClip clip) => _sfx.PlayOneShot(clip);

    public void ChangeMusic(AudioClip newClip, float fadeDuration = 1f)
    {
        StartCoroutine(ChangeMusicRoutine(newClip, fadeDuration));
    }

    private IEnumerator ChangeMusicRoutine(AudioClip newClip, float duration)
    {
        yield return _fader.FadeOut(_musicSource, duration);
        _music.Play(newClip);
        _musicSource.volume = 1f;
    }

    public void SetMasterVolume(float volume)
    {
        _music.SetVolume(volume);
        _sfx.SetVolume(volume);
    }
}