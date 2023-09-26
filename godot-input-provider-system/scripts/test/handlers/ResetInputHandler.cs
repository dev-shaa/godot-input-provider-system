public partial class ResetInputHandler : TestInputHandler
{
    public override void Handle(TestInputState state)
    {
        state.Reset();
    }
}