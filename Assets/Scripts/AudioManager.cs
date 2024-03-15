using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager _instance = null;

    public static AudioManager Instance => _instance;
    [Header("AudioSources")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("AudioClips")]
    public AudioClip music;
    public AudioClip assaultShootSound;
    public AudioClip assaultSpecialSound;
    public AudioClip rushShootSound;
    public AudioClip rushSpecialSound;
    public AudioClip scoutShootSound;
    public AudioClip scoutSpecialSound;
    public AudioClip enemyShootSound;
    public AudioClip enemyDeathSound;
    public AudioClip playerDeathSound;
    public AudioClip bulletHitSound;
    public AudioClip playerHitSound;
    public AudioClip startSound;



    private void Awake()
    {
        // Singleton
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            _instance = this;
            this.transform.SetParent(null);
        }
    }

    private void Start()
    {
        musicSource.clip = music;
        musicSource.Play();
    }
    public void PlaySFX(AudioClip clip, float _pitch = 1, float _volume = 1)
    {
        SFXSource.PlayOneShot(clip);
    }
}
