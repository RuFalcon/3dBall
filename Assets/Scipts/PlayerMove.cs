using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody _rb;
    [SerializeField] Transform _cameraCenter;
    [SerializeField] float _torqueValue;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.maxAngularVelocity = 500;
    }

    void FixedUpdate()
    {
        _rb.AddTorque(_cameraCenter.right * Input.GetAxis("Vertical") * _torqueValue);
        _rb.AddTorque(-_cameraCenter.forward * Input.GetAxis("Horizontal") * _torqueValue);
    }
}
