using Godot;
using InputProvider;

public class TestInputHandler : IInputHandler<TestInputState>
{
    public void Handle(TestInputState state)
    {
        state.movementInput = Input.GetVector("left", "right", "forward", "back");
        state.fire = Input.IsActionPressed("fire");
    }
}