public class DamageButton : HealthInterractButton
{
    protected override void OnClick()
    {
        if (Target.IsAlive)
            Target.AcceptDamage(Value);
    }
}
