using System.Collections;
using System.Collections.Generic;
using _SnapCity.GameEvents;
using UnityEngine;

public class GreatBall : MonoBehaviour
{
    [SerializeField] private PlayerInput _input;

    [SerializeField] private Rigidbody _rb;

    [SerializeField, Min(0.001f)] private float _force;

    [SerializeField]
    private Vector3 _torqueNormal;

    [SerializeField]
    private ForceMode _forceMode;
    private void Update()
    {
        Debug.Log("----------------");
        Debug.Log($"Velocity: {_rb.velocity}");
        Debug.Log($"Angular Velocity: {_rb.angularVelocity}");
        Debug.Log("----------------");
    }

    private void FixedUpdate()
    {
        _rb.AddTorque(_force * _input.V * _torqueNormal, _forceMode);
    }
}
