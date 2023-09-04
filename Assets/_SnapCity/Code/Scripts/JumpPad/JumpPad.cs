using System;
using System.Collections;
using System.Collections.Generic;
using _SnapCity.GameEvents;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    [SerializeField] private FloatVariable _power;

    [SerializeField] private float _powerRate = 0.5f;
    
    [SerializeField] private bool _useCurve;
    [SerializeField] private AnimationCurve _powerRateCurve;
    
    [SerializeField] private FloatVariable _maxPower;

    [SerializeField] private GameEvent _onGameInited;

    [SerializeField] private FloatVariable _multiplier;
    [SerializeField] private FloatVariable _maxSlidingTime;
    
    private float _currentPower;

    private void Start()
    {
        if (!_useCurve) return;

        for (int i = 0; i < _powerRateCurve.length; i++)
        {
            var keyFrame = _powerRateCurve[i];

            keyFrame.time *= _maxPower.Value;

            //_powerRateCurve.MoveKey(i, keyFrame);
        }
    }

    private void Update()
    {
        GetInput();
        Power();
    }

    private void Power()
    {
        if (_useCurve)
            _powerRate = _powerRateCurve.Evaluate(_power.Value);
        _currentPower += Time.deltaTime * _powerRate;
        _power.Value = Mathf.PingPong(_currentPower, _maxPower.Value);
    }

    private void GetInput()
    {
        if(!Input.GetKeyDown(KeyCode.Space)) return;
        _multiplier.Value = 1 + _power.Value / _maxPower.Value;
        _maxSlidingTime.Value = 35 + (_multiplier.Value * 15);
        Debug.Log(_maxSlidingTime.Value);
        Debug.Log(_power.Value);
        _onGameInited.Raise();
    }
}
