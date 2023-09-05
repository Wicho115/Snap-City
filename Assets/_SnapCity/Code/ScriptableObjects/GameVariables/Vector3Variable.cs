using System;
using UnityEngine;

[CreateAssetMenu, Serializable]
public class Vector3Variable : GameVariable<Vector3>
{
    protected override Vector3 GetValue(Vector3 value)
    {
        return base.GetValue(value);
    }
}
