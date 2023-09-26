using Godot;

namespace InputProvider
{

    public abstract partial class NodeInputProvider<T> : Node, IInputProvider<T> where T : IInputState
    {
        public abstract T GetState();
    }

}