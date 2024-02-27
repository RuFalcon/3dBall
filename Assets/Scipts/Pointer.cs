using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    [SerializeField] CoinManager _coinsManager;
    [SerializeField] Coin _closestCoin;
    void Update()
    {
        _closestCoin = _coinsManager.GetClosest(transform.position);
        Debug.DrawLine(transform.position, _closestCoin.transform.position);

        Vector3 totarget = _closestCoin.transform.position - transform.position;
        Vector3 totargetXZ = new Vector3(totarget.x, 0, totarget.z);
        transform.rotation = Quaternion.LookRotation(totargetXZ);
    }
}
