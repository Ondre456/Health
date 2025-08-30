using UnityEngine;

public abstract class HpIndicator : MonoBehaviour
{
    [SerializeField] protected HealthController Target;

    protected void Awake()
    {
        Target.OnChanged += TargetHpChannged;
    }

    private void OnDestroy()
    {
        Target.OnChanged -= TargetHpChannged;
    }

    protected abstract void TargetHpChannged();
}
