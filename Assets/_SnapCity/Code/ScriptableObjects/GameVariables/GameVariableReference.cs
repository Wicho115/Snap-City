using System;
using UnityEngine;

[Serializable]
public class GameVariableReference<T>
{
    [SerializeField] private bool _useConstat = true;
    [SerializeField] private T _constantValue;
    [SerializeField] private GameVariable<T> _variable;

    public T Value
    {
        get
        {
            return _useConstat ? _constantValue : _variable.Value;
        }
    }
}
