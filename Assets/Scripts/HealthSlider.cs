using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthSlider : HealthIndicator
{
    private Slider _slider;

    private void Awake()
    {
        base.Awake();
        _slider = GetComponent<Slider>();
        _slider.maxValue = Target.MaxHealth;
        _slider.value = _slider.maxValue;
    }

    protected override void TargetHealthChannged()
    {
        _slider.value = Target.Value;
    }
}
