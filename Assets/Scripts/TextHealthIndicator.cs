using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class TextHealthIndicator : HealthIndicator
{
    private TextMeshProUGUI _healthTextBox;
    private int _targetMaxHealth;

    private void Awake()
    {
        base.Awake();
        _healthTextBox = GetComponent<TextMeshProUGUI>();
        _targetMaxHealth = Target.MaxHealth;
        _healthTextBox.text = $"{_targetMaxHealth}/{_targetMaxHealth}";
    }

    protected override void TargetHealthChannged()
    {
        _healthTextBox.text = $"{Target.Value}/{_targetMaxHealth}";
    }
}
