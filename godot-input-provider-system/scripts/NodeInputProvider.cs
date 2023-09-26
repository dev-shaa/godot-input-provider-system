using Godot;

namespace InputProvider
{

    /// <summary>
    /// An input provider which can be instantiated in a Godot scene.
    /// </summary>
    /// <typeparam name="T">The type of input state to handle.</typeparam>
    public abstract partial class NodeInputProvider<T> : Node, IInputProvider<T> where T : IInputState
    {
        public abstract T GetState();
    }

}