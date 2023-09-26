using System.Collections.Generic;

/// <summary>
/// An input provider which follows the chain of command pattern to get the input state.
/// </summary>
/// <typeparam name="T">The type of the input state.</typeparam>
public abstract partial class ChainInputProvider<T> : InputProvider<T> where T : IInputState
{
    private readonly T state;

    /// <summary>
    /// Creates a new chain of command input provider.
    /// </summary>
    public ChainInputProvider()
    {
        state = CreateNewState();
    }

    public override T GetState()
    {
        foreach (var inputHandler in GetInputHandlers())
            inputHandler.Handle(state);

        return state;
    }

    /// <summary>
    /// Instantiates a new input state.
    /// </summary>
    /// <returns>A new input state.</returns>
    protected abstract T CreateNewState();

    /// <summary>
    /// Gets all input handlers of this provider.
    /// </summary>
    /// <returns>An iterator of input handlers.</returns>
    protected abstract IEnumerable<IInputHandler<T>> GetInputHandlers();
}