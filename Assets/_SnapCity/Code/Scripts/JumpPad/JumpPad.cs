using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    [SerializeField] private FloatVariable _power;

    [SerializeField] private float _powerRate = 0.5f;
    [SerializeField] private FloatVariable _maxPower;

    private float _currentPower;

    private void Update()
    {
        _currentPower += Time.deltaTime * _powerRate;
        _power.Value = Mathf.PingPong(_currentPower, _maxPower.Value);
    }
}
