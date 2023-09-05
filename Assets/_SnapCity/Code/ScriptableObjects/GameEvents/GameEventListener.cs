using System;
using _SnapCity.GameEvents;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    [SerializeField] private GameEvent _gameEvent = null;
    [SerializeField] private UnityEvent _unityEvent = new();

    private void OnEnable() => _gameEvent.AddListener(this);
    private void OnDisable() => _gameEvent.RemoveListener(this);

    public void OnGameEventRaised() => _unityEvent.Invoke();
}
