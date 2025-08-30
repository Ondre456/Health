using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public abstract class HealthInterractButton : MonoBehaviour
{
    [SerializeField] protected int Value;
    [SerializeField] protected HealthController Target;

    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(OnClick);
    }

    private void OnDestroy()
    {
        _button.onClick.RemoveListener(OnClick);
    }

    protected abstract void OnClick();
}
