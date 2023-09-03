using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class SliderVisualizer : MonoBehaviour
{
    [FormerlySerializedAs("_scrollbar")] [SerializeField] private Slider _slider;
    [SerializeField] private FloatVariable _float;
    [SerializeField] private FloatVariable _maxFloat;

    private void Start()
    {
        _slider.maxValue = _maxFloat.Value;
    }

    private void DisplayVar(float var)
    {
        _slider.value = var;
    }
    
    private void OnEnable()
    {
        _float.OnVariableChanged += DisplayVar;
    }

    private void OnDisable()
    {
        _float.OnVariableChanged -= DisplayVar;
    }
}
