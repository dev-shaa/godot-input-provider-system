using Godot;

/// <summary>
/// An input handler which check for user's input.
/// </summary>
public class TestInputHandler : IInputHandler<TestInputState>
{
    public void Handle(TestInputState state)
    {
        state.movementInput = Input.GetVector("left", "right", "forward", "back");
    }
}