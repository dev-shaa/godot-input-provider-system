using Godot;
using InputProvider;

public class TestInputState : IInputState
{
    public Vector2 movementInput;
    public bool fire;

    public TestInputState()
    {
        Reset();
    }

    public void Reset()
    {
        movementInput = Vector2.Zero;
        fire = false;
    }
}