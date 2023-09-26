using Godot;
using InputProvider;

public abstract partial class TestInputHandler : Node, IInputHandler<TestInputState>
{
    public abstract void Handle(TestInputState state);
}