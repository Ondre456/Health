using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class TextHealthIndicator : HpIndicator
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

    protected override void TargetHpChannged()
    {
        _healthTextBox.text = $"{Target.Health}/{_targetMaxHealth}";
    }
}
