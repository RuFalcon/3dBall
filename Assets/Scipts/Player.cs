using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] CoinManager _coinsManager;
    [SerializeField] SoundManager _soundsManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Coin>())
        {
            _coinsManager.CollectCoin(other.GetComponent<Coin>());
            _soundsManager.PickupSoundPlay();
        }
    }
}
