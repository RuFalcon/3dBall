using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    [SerializeField] GameObject _coinPrefab;
    [SerializeField] Text _coinsText;
    List<Coin> _coinsList = new List<Coin>();
    void Start()
    {
        for (int i = 0; i < 50; i++)
        {
            Vector3 position = new Vector3(Random.Range(-20f, 20f), 0.5f, Random.Range(-20f, 20f));
            GameObject newCoin =  Instantiate(_coinPrefab, position, Quaternion.identity);
            _coinsList.Add(newCoin.GetComponent<Coin>());
        }
        UpdateText();
    }

    public void CollectCoin(Coin coin)
    {
        _coinsList.Remove(coin);
        Destroy(coin.gameObject);
        UpdateText();
    }

    void UpdateText()
    {
        _coinsText.text = "Осталось собрать: " + _coinsList.Count.ToString();
    }

    public Coin GetClosest(Vector3 point)
    {
        float minDistance = Mathf.Infinity;
        Coin closestCoin = null;
        for (int i = 0; i < _coinsList.Count; i++)
        {
            float distance = Vector3.Distance(point, _coinsList[i].transform.position);
            if (distance < minDistance)
            {
                minDistance = distance;
                closestCoin = _coinsList[i];
            }
        }
        return closestCoin;
    }
}
