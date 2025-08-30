public class DamageButton : HealthInterractButton
{
    protected override void OnClick()
    {
        Target.AcceptDamage(Value);
    }
}
