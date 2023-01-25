using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }


    public AudioSource audioSource;
    public AudioClip[] sfxCageRattle;
    public AudioClip[] sfxLoudMetalClang;
    public AudioClip[] sfxLightMetalImpact;
    public AudioClip[] sfxBoneImpact;
    public AudioClip[] sfxClearMetalImpact;
    public float volume;


    // SOUND EFFECTS - Plays a random sound effect from an array
    public void PlaySfxCageRattle()
    {
        audioSource.PlayOneShot(sfxCageRattle[Random.Range(0, sfxCageRattle.Length)], volume);
        return;
    }

    public void PlaySfxLoudMetalClang()
    {
        audioSource.PlayOneShot(sfxLoudMetalClang[Random.Range(0, sfxLoudMetalClang.Length)], volume);
        return;
    }

    public void PlaySfxLightMetalImpact()
    {
        audioSource.PlayOneShot(sfxLightMetalImpact[Random.Range(0, sfxLightMetalImpact.Length)], volume);
        return;
    }

    public void PlaySfxBoneImpact()
    {
        audioSource.PlayOneShot(sfxBoneImpact[Random.Range(0, sfxBoneImpact.Length)], volume);
        return;
    }

    public void PlaySfxClearMetalImpact()
    {
        audioSource.PlayOneShot(sfxClearMetalImpact[Random.Range(0, sfxClearMetalImpact.Length)], volume);
        return;
    }
}
