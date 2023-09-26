using Godot;

public abstract partial class InputProvider<T> : Node, IInputProvider<T> where T : IInputState
{
    public abstract T GetState();
}