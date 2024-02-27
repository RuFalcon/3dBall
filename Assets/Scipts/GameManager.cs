using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    string _currentSceneName;
    [SerializeField] Transform _playerTransform;

    void Awake()
    {
        _currentSceneName = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        if (_playerTransform.position.y < -5)
        {
            SceneManager.LoadScene(_currentSceneName);
        }
    }
}
