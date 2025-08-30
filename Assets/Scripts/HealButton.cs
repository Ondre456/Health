public class HealthButton : HealthInterractButton
{
    protected override void OnClick()
    {
        Target.AcceptHeal(Value);
    }
}
