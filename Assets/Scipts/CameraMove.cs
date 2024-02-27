using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Transform _playerTransform;
    [SerializeField] Rigidbody _playerRigidbody;
    List<Vector3> _velocitiesList = new List<Vector3>();

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            _velocitiesList.Add(Vector3.zero);
        }
    }

    void Update()
    {
        Vector3 summ = Vector3.zero;
        for (int i = 0;i < _velocitiesList.Count;i++)
        {
            summ += _velocitiesList[i];
        }
        transform.position = _playerTransform.position;
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(summ), Time.deltaTime * 10f);
    }

    void FixedUpdate()
    {
        _velocitiesList.Add(_playerRigidbody.velocity);
        _velocitiesList.RemoveAt(0);
    }
}
