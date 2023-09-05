using System;
using System.Collections;
using System.Collections.Generic;
using _SnapCity.GameVariables;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private Vector3Reference _cameraOffset;

    [SerializeField] private Transform _player;

    private Transform _t;

    private void Awake()
    {
        _t = transform;
    }

    private void LateUpdate()
    {
        _t.position = _player.position - _cameraOffset.Value;
    }
}
