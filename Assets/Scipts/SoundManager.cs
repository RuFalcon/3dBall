using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    AudioSource _audioSource;
    [SerializeField] AudioClip _pickupCoin;

    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void PickupSoundPlay()
    {
        _audioSource.PlayOneShot(_pickupCoin);
    }
}
