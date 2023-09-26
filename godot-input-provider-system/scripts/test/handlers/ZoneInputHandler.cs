public partial class ZoneInputHandler : TestInputHandler
{
    public override void Handle(TestInputState state)
    {
        state.movementInput.X += 0.5f;
    }
}