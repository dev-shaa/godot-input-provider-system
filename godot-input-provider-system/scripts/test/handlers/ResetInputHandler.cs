/// <summary>
/// An handler which resets the given input state.
/// </summary>
public partial class ResetInputHandler : TestInputHandler
{
    public override void Handle(TestInputState state)
    {
        state.Reset();
    }
}