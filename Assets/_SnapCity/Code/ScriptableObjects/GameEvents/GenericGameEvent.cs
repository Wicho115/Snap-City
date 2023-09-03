using System;
using UnityEngine;

namespace _SnapCity.GameEvents
{
    public abstract class GenericGameEvent<T> : ScriptableObject
    {
        public event Action<T> Event;

        public virtual void Raise(T arg)
        {
            Event?.Invoke(arg);
        }
    }
}