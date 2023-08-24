using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameVariable<T> : ScriptableObject
{
    public event Action<T> OnVariableChanged;
    protected T _value;
    public T Value
    {
        get
        {
            return _value;
        }
        set
        {
            _value = OnValueChanged(value);
            OnVariableChanged?.Invoke(_value);
        }
    }

    protected virtual T OnValueChanged(T value)
    {
        return value;
    }
}
