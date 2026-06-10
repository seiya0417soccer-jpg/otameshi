using UnityEngine;

public class AudioTester : MonoBehaviour
{
    [SerializeField] private AudioFacade _audioFacade;
    [SerializeField] private AudioClip _musicClip;
    [SerializeField] private AudioClip _sfxClip;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M)) _audioFacade.PlayMusic(_musicClip);
        if (Input.GetKeyDown(KeyCode.S)) _audioFacade.PlaySfx(_sfxClip);
        if (Input.GetKeyDown(KeyCode.V)) _audioFacade.SetMasterVolume(0.3f);
    }
}