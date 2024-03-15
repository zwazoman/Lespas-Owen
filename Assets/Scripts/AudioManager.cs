using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager _instance = null;

    public static AudioManager Instance => _instance;

    [SerializeField] AudioClip assaultShootSound;
    [SerializeField] AudioClip assaultSpecialStartSound;
    [SerializeField] AudioClip assaultSpecialEndSound;
    [SerializeField] AudioClip rushShootSound;
    [SerializeField] AudioClip rushSpecialSound;
    [SerializeField] AudioClip scoutShootSound;
    [SerializeField] AudioClip scoutSpecialSound;
    [SerializeField] AudioClip enemyShootSound;
    [SerializeField] AudioClip enemyDeathSound;
    [SerializeField] AudioClip playerDeathSound;
    [SerializeField] AudioClip bulletHitSound;
    [SerializeField] AudioClip playerHitSound;
    [SerializeField] AudioClip startSound;


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
            DontDestroyOnLoad(this);
        }
    }

    public void PlayAssaultShoot() { PlaySound(assaultShootSound); }

    public void PlayAssaultSpecialStart() { PlaySound(assaultSpecialStartSound); }

    public void PlayAssaultSpecialEnd() {  PlaySound(assaultSpecialEndSound); }

    public void PlayRushShoot() { PlaySound(rushShootSound); }

    public void PlayRushSpecial() {  PlaySound(rushSpecialSound); }

    public void PlayScoutShoot() { PlaySound(scoutShootSound); }

    public void PlayScoutSpecial() {  PlaySound(scoutSpecialSound); }

    public void PlayEnemyShoot() { PlaySound(enemyShootSound); }

    public void PlayEnemyDeath() { PlaySound(enemyDeathSound); }

    public void PlayPlayerDeath() { PlaySound(playerDeathSound); }

    public void PlayBulletHit() { PlaySound(bulletHitSound); }

    public void PlayPlayerHit() { PlaySound(playerHitSound); }

    public void PlayStart() { PlaySound(startSound); }


    public void PlaySound(AudioClip clip, float _pitch = 1, float _volume = 1)
    {
        AudioSource source = gameObject.AddComponent<AudioSource>();
        source.volume = _volume;
        source.pitch = _pitch;
        source.PlayOneShot(clip);
        Destroy(source, 3);
    }
}
