using Godot;

public class TestInputState : IInputState
{
    public Vector2 movementInput;

    public TestInputState()
    {
        Reset();
    }

    public void Reset()
    {
        movementInput = Vector2.Zero;
    }
}