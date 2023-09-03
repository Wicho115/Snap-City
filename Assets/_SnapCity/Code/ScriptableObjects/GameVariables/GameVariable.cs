using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public abstract class GameVariable<T> : ScriptableObject
{
    public event Action<T> OnVariableChanged;
    [SerializeField] protected T _value;
    public T Value
    {
        get
        {
            return _value;
        }
        set
        {
            _value = GetValue(value);
            OnVariableChanged?.Invoke(_value);
        }
    }

    protected virtual T GetValue(T value)
    {
        return value;
    }
    
    #if UNITY_EDITOR
    private void OnValidate()
    {
        OnVariableChanged?.Invoke(_value);
    }
    #endif
}
